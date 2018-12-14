using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.PluralSight.CSharpCollections.Arrays
{
    // Reversing Arrays
    class M04P08
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

            // Array.Reverse() - does not create a new array
            // .Reverse() is a static method of the Array class
            //Array.Reverse(daysOfWeek);

            // If we were to use the LINQ extension method for reversing an array
            // LINQ methods return something that you can enumerate and which you can easily
            // copy to a collection if you want
            //IEnumerable<string> reversed = daysOfWeek.Reverse();

            string[] reversed = daysOfWeek.Reverse().ToArray();

            foreach (string day in reversed)
            {
                Console.WriteLine(day);
            }
        }
    }
}
