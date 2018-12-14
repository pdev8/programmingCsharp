using System;

namespace CSP.Algorithms
{
    public class Fizzbuzz
    {
        public static void Run()
        {
            for (var i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else
                {
                    Console.Write(i);
                }
                Console.Write(" ");
            }
        }
    }
}
