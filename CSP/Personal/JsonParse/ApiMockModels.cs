using System;
using System.Collections.Generic;

namespace CSP.Personal.JsonParse
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
}