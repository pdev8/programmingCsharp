using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSP.Personal.JsonParse
{
    public class ApiGenericMethod
    {
        public static List<Order> orders;

        public static void Run()
        {
            orders = new List<Order>()
            {
                new Order
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
                new Order
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

            var responseString = SerializeObject(orders);

            var response = ParseResponse<List<Order>>(responseString);
        }

        public static string SerializeObject(List<Order> orders)
        {
            return JsonConvert.SerializeObject(orders);
        }

        public static List<Order> ParseResponse<T>(string response)
        {
            var model = JsonConvert.DeserializeObject<T>(response);

            var info = model.GetType().GetProperties();

            return new List<Order>();
        }
    }
}