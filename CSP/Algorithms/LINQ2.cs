using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.Algorithms
{
    public class LINQ2
    {
        public class MyClass
        {
            public int id { get; set; }

            public void print()
            {
                Console.WriteLine("id - " + id);
            }
        }
        public class Order : MyClass
        {
            public Customer customer { get; set; }
            public List<OrderItem> items { get; set; }
            public double tax { get; set; }
            public double total { get; set; }

            public new void print()
            {
                base.print();
                Console.WriteLine("tax - " + this.tax);
                Console.WriteLine("total - " + this.total);
            }
        }

        public class Customer : MyClass
        {
            public string name { get; set; }
            public Address address { get; set; }
        }

        public class Address : MyClass
        {
            public string street { get; set; }
            public string zip { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class OrderItem : MyClass
        {
            public string name { get; set; }
            public double price { get; set; }
            public int qty { get; set; }
        }

        /*****************************************************************/

        //Select and return a list of the customer address for all orders that have more then 1 order item associated with it
        public static List<Address> getAddressList()
        {
            return orders.Where(s => s.items.Count > 1).Select(s => s.customer.address).ToList();
        }

        //select all order items from all orders as a list
        public static List<OrderItem> getAllOrderItems()
        {
            return orders.SelectMany(s => s.items).ToList();
            ////return orders.Select(a => a.items).SelectMany(a => a).ToList();
        }

        //update each orders tax and total based on it's order items
        public static void setTotals()
        {
            orders.ForEach(s =>
            {
                s.tax = s.items.Sum(n => n.price * n.qty) * 0.0775;
                s.total = s.tax + s.items.Sum(n => n.price * n.qty);
            });
        }

        /*****************************************************************/





        public static List<Order> orders;
        public static void Run()
        {

            orders = new List<Order>()
            {
                new Order()
                {
                    id = 1,
                    customer = new Customer()
                    {
                        id = 100,
                        name = "Joes Bike Shop",
                        address = new Address()
                        {
                            id = 500,
                            street = "123 fake st.",
                            zip = "95264",
                            city = "LA",
                            state = "CA"
                        }
                    },
                    items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            id = 1000,
                            name = "button",
                            price = 25.25,
                            qty = 21
                        },
                        new OrderItem()
                        {
                            id = 1001,
                            name = "box",
                            price = 13.21,
                            qty = 7
                        }
                    }
                },
                new Order()
                {
                    id = 2,
                    customer = new Customer()
                    {
                        id = 101,
                        name = "Billy's Pawn Shop",
                        address = new Address()
                        {
                            id = 501,
                            street = "321 faker ave.",
                            zip = "92175",
                            city = "Irvine",
                            state = "CA"
                        }
                    },
                    items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            id = 1002,
                            name = "button",
                            price = 25.25,
                            qty = 2
                        },
                        new OrderItem()
                        {
                            id = 1003,
                            name = "calendar",
                            price = 10.75,
                            qty = 10
                        }
                    }
                }
            };

            //q1 customer addresses
            var addresses = getAddressList();
            addresses.ForEach(a => a.print());
            //q2 order items
            var items = getAllOrderItems();
            //items.ForEach(i => i.print());
            //q3 set totals
            setTotals();


            foreach (var order in orders)
            {
                order.print();
                order.customer.print();
                order.customer.address.print();
                foreach (var item in order.items)
                {
                    item.print();
                }
            }

            Console.ReadLine();
        }
    }
}