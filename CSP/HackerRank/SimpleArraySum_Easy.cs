using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.HackerRank
{
    public class SimpleArraySum_Easy
    {
        public static void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = SimpleArraySum(n, arr);
            Console.WriteLine(result);
        }

        static int SimpleArraySum(int n, int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
