using System;

namespace CSP.Mosh.CSharpBeginner
{
    public static class S05Lec45
    {
        public static void Run()
        {
            string name = "John Smith";

            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.Write(name[i]);                
            //}

            //Console.WriteLine();

            // For enumerable object: array, list, string, etc.
            foreach (char character in name)
            {
                Console.Write(character);
            }

            Console.WriteLine();

            int[] numbers = { 1, 2, 3, 4 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
