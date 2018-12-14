using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.PluralSight.CSharpCollections.Arrays
{
    // Finding Elements
    class M04P10
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

            //int indexOfTues = Array.IndexOf(daysOfWeek, "Tuesday");
            //Console.WriteLine(indexOfTues);

            // Using Array.FindIndex()
            // Where x is each element and x[0] is the first character in the string
            //int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
            //Console.WriteLine(indexOfW);
            //Console.WriteLine(daysOfWeek[indexOfW]);

            string[] allWith6Chars = Array.FindAll(daysOfWeek, x => x.Length == 6);
            foreach (string item in allWith6Chars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
