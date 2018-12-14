using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    class IC43
    {
        /// <summary>
        /// Write a method to merge the arrays of orders into one sorted array
        /// </summary>
        public static void Run()
        {
            int[] myArray = { 3, 4, 6, 10, 11, 15 };
            int[] alicesArray = { 1, 5, 8, 12, 14, 19 };

            foreach (int num in MergeArrays(myArray, alicesArray))
            {
                Console.WriteLine(num);
            }
        }

        static int[] MergeArrays(int[] myArray, int[] alicesArray)
        {
            int[] mergedArray = new int[myArray.Length + alicesArray.Length];

            int currentIndexAlices = 0;
            int currentIndexMine = 0;
            int currentIndexMerged = 0;

            while (currentIndexMerged < mergedArray.Length)
            {
                bool isMyArrayExhausted = currentIndexMine >= myArray.Length;
                bool isAlicesArrayExhausted = currentIndexAlices >= alicesArray.Length;

                if (!isMyArrayExhausted && (isAlicesArrayExhausted ||
                                            (myArray[currentIndexMine] < alicesArray[currentIndexAlices])))
                {
                    mergedArray[currentIndexMerged] = myArray[currentIndexMine];
                    currentIndexMine++;
                }
                else
                {
                    mergedArray[currentIndexMerged] = alicesArray[currentIndexAlices];
                    currentIndexAlices++;
                }
                currentIndexMerged++;

            }

            return mergedArray;
        }
    }
}
