using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSP.Mosh.CSharpIntermediate.Classes.SharedClasses;

namespace CSP.Mosh.CSharpIntermediate.Classes
{
    public class S2P7
    {
        public static void Run()
        {
            var customer = new Customer(4);
            var order = new Order();

            customer.Orders.Add(order);
        }
    }

    internal class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        // Before the body of this constructor is executed, the parameterless constructor will be called
        // because of the "this" keyword
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
