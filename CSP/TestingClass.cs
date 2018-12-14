using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP
{
    class TestingClass
    {
        public static void Run()
        {
            ConvertIntToRomanNumeral(12);
        }

        public static void ConvertIntToRomanNumeral(int number)
        {
            Dictionary<int, string> conversion = new Dictionary<int, string>()
            {
                {1, "I" },
                {2, "II" },
                {3, "III" },
                {4, "IV" },
                {5, "V" },
                {6, "VI" },
                {7, "VII" },
                {8, "VIII" },
                {9, "IX" },
                {10, "X" },
                {50, "L" }
            };

            while (number != 0)
            {
                int temp = number / 10;
                number %= 10;
                Console.Write(conversion[number]);
                number = number + temp * 10;
                number /= 10;
            }
        }

    }
}
