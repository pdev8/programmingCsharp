using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.Arrays
{
    class M04P02
    {
        public static void Run()
        {
            int[] x1 = { 1, 4, 9, 16 };
            // x2 stores the address that points to the memory allocation of x1
            // Any changes made to x1 is reflected on x2
            int[] x2 = x1;

            x1[0] = -3;

            // == compares references (does not compare values)
            int[] x3 = { 1, 4, 9, 16 };

            Console.WriteLine($"RefEquals(x1, x2): {ReferenceEquals(x1, x2)}");
            
            Console.WriteLine($"x1 == x2 is {x1 == x2}");
            Console.WriteLine($"x1 == x3 is {x1 == x3}");
        }
    }
}
