using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    // Is it possible to store mixed datatypes such as int, string, float, char
    // all in one array?

    class _7MixedDataTypes
    {
        class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public override string ToString()
            {
                return this.Name;
            }
        }

        public static void Run()
        {
            object[] array = new object[3];
            array[0] = 101;
            array[1] = "C#";
            Customer c = new Customer();
            c.ID = 55;
            c.Name = "Paul";
            array[2] = c;

            foreach (object obj in array)
            {
                Console.WriteLine(obj);
            }
        }
    }

    // Toptal's Explanation
    // Yes! It is possible to do so because the array can be of type object that can
    // not only store any datatype but also the object of the class
}
