using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.Personal
{
    public class NullCollections
    {
        public static void Run()
        {
            var emptyListOfStrings = new List<string>();

            Console.WriteLine($"List of empty strings: {emptyListOfStrings.FirstOrDefault()}");
        }
    }
}