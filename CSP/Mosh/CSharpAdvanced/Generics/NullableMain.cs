using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.Generics
{
    class NullableMain
    {
        public static void Run()
        {
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value?" + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());
        }
    }
}
