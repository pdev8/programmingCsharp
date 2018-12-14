using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.HackerRank
{
    class MirthEx05
    {
        public static void Run()
        {
            Console.WriteLine(MinimumUniqueArraySum(new []{3, 2, 1, 2, 7}));
        }

        static int MinimumUniqueArraySum(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                while (arr[i] <= arr[i - 1])
                {
                    arr[i]++;
                }
            }

            return arr.Sum();
        }
    }
}
