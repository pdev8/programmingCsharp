using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.Arrays
{
    // Sorting Arrays
    class M04P09
    {
        public static void Run()
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //Array.Sort(daysOfWeek);

            // Sorting the array using the IComparer<T> interface and sorting
            // the array by string length (shortest to longest)
            StringLengthComparer comparer = new StringLengthComparer();
            Array.Sort(daysOfWeek, comparer);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }

        // Need to define a class that implements the IComparer<string> interface
        class StringLengthComparer : IComparer<string>
        {
            public int Compare(string x, string y) => x.Length.CompareTo(y.Length);
        }
    }
}
