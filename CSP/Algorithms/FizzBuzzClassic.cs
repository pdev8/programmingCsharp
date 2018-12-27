using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.Utilities;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Write a program that console logs the numbers from 1 to n.
    /// But for multiples of 3 print "fizz" instead of the number and
    /// for the multiples of 5 print "buzz". For numbers which are
    /// multiples of both 3 and 5 print "fizzbuzz"
    ///
    /// 
    /// </summary>
    public class FizzBuzzClassic
    {
        public static void Run()
        {
            FizzBuzz(5);
            FizzBuzz2(16);
        }

        public static void FizzBuzz(int number)
        {
            for (var i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                {
                    Console.Write("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("fizz");
                }
                else
                {
                    Console.Write($"{ i }");
                }

                Console.Write(" ");
            }
        }

        public static void FizzBuzz2(int number)
        {
            Enumerable.Range(1, number).ForEach(s =>
            {
                if (s % 15 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (s % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (s % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(s);
                }

                Console.Write(" ");
            });
        }
    }
}
