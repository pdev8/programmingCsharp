using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Fibonacci
{
    class FibonacciParallel
    {
        public static int[] FibonacciSequence(int fibCount)
        {
            int[] seq = new int[fibCount];

            seq[0] = 0;
            seq[1] = 1;

            int currentTotal = seq[0] + seq[1];

            for (int i = 2; i < fibCount; i++)
            {
                seq[i] = currentTotal;

                int prev = seq[i - 1];

                currentTotal += prev;
            }

            return seq;
        }
    }
}
