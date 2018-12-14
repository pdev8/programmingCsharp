using System;
using System.Collections.Generic;

namespace CSP.MSDN.Arrays
{
    class ReverseComparer : IComparer<string>
    {
        public int Compare(string x, string y) => y.CompareTo(x);
    }

    class BinarySearchEx
    {
        public static void Run()
        {
            string[] dinosaurs =
            {
                "Pachycephalosaurus",
                "Amargasaurus",
                "Tyrannosaurus",
                "Mamenchisaurus",
                "Deinonychus",
                "Edmontosaurus"
            };

            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            ReverseComparer rc = new ReverseComparer();

            Console.WriteLine("\nSort");
            Array.Sort(dinosaurs, rc);

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nBinarySearch for 'Coelophysis':");
            int index = Array.BinarySearch(dinosaurs, "Coelophysis", rc);
            ShowWhere(dinosaurs, index);

            Console.WriteLine("\nBinarySearch for 'Tyrannosaurus':");
            index = Array.BinarySearch(dinosaurs, "Tyrannosaurus");
            ShowWhere(dinosaurs, index);

            Console.WriteLine(index);
        }

        static void ShowWhere<T>(T[] array, int index)
        {
            if (index < 0)
            {
                index = ~index;

                Console.Write("Not found. Sorts between: ");

                if (index == 0)
                    Console.Write("beginning of array and ");
                else
                    Console.Write($"{array[index - 1]} and ");

                if (index == array.Length)
                    Console.WriteLine("end of array.");
                else
                    Console.WriteLine($"{array[index]}.");
            }
            else
            {
                Console.WriteLine($"Found at index {index}");
            }
        }
    }
}
