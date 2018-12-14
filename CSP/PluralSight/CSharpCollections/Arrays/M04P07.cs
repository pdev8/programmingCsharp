using System;
using System.Linq;

namespace CSP.PluralSight.CSharpCollections.Arrays
{
    class M04P07
    {
        public static void Run()
        {
            int[] squares = { 1, 4, 9, 16 };

            int[] copy = squares.ToArray(); // LINQ extension method

            //int[] copy = new int[4];
            // CopyTo doesn't return a new array, instead you have to instantiate a new array
            // and pass it as a parameter
            //squares.CopyTo(copy, 0);

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine($"squares == copy? {squares == copy}");
        }
    }
}
