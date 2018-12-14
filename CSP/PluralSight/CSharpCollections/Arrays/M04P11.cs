using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.Arrays
{
    class M04P11
    {
        public static void Run()
        {
            string[] sortedDays =
            {
                "Friday",
                "Monday",
                "Saturday",
                "Sunday",
                "Thursday",
                "Tuesday",
                "Wednesday"
            };

            int indexOfSun = Array.BinarySearch(sortedDays, "Sunday");
            Console.WriteLine("Index is " + indexOfSun);
        }
    }
}
