using System;
using System.Linq;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Given an integer, return an integer that is the reverse ordering
    /// of numbers.
    /// --- Examples
    ///     reverseInt(15) === 51
    ///     reverseInt(981) === 189
    ///     reverseInt(500) === 5
    ///     reverseInt(-15) === -51
    ///     reverseInt(-90) === -9
    /// 
    /// </summary>
    public class ReversingInt
    {
        public static void Run()
        {
            Console.WriteLine(ReverseInt(15));
            Console.WriteLine(ReverseInt(981));
            Console.WriteLine(ReverseInt(500));
            Console.WriteLine(ReverseInt(-15));
            Console.WriteLine(ReverseInt(-90));
            Console.WriteLine(ReverseInt(-104871));
        }

        public static int ReverseInt(int number)
        {
            return Math.Sign(number) * Convert.ToInt32(new string(number.ToString().Where(char.IsDigit).Reverse().ToArray()));
        }
    }
}