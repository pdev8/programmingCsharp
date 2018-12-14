using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    class _1SumOfArray
    {
        public static void Run()
        {
            // Pcode
            Console.WriteLine(SumOfEvenIntegersInArray(new[] { 1, 2, 3, 4 })); // 6

            // Tcode
            Console.WriteLine(TotalAllEvenNumbers(new [] {1, 2, 4, 5, 6, 7, 8, 9, 10})); // 30

            Console.WriteLine(Calculate(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })); // 30
        }

        // Paul's code
        static int SumOfEvenIntegersInArray(int[] myArr)
        {
            // Things to avoid:
            
            // 1. Accumulator
            int sum = 0;
            // 2. Loop
            for (int i = 0; i < myArr.Length; i++)
            {
                // 3. Conditional Statement
                if (myArr[i] % 2 == 0)
                    sum += myArr[i];
            }
            return sum;
        }

        // Toptal's code
        #region Tip
        // Consider the fact that if the array was very large then an int
        // might not be large enough to store the value (cast to long to 
        // avoid an overflow)
        #endregion
        static long TotalAllEvenNumbers(int[] intArray) => intArray.Where(i => i % 2 == 0).Sum(i => (long)i);

        static int Calculate(int[] intArray)
        {
            return intArray.Sum();
        }
    }
}
