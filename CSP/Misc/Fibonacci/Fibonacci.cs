using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP
{
    class Fibonacci
    {
        // Fibonacci method (1 parameter) - returns the sequence depending on the value of parameter
        public static int[] FibonacciSequence(int value)
        {
            int[] seq = new int[value];

            seq[0] = 0;

            if (value != 0 && value != 1)
            {
                seq[1] = 1;
                int currentSum = seq[0] + seq[1];

                for (int i = 2; i < value; i++)
                {
                    seq[i] = currentSum;

                    int previous = seq[i - 1];

                    currentSum = seq[i] + previous;
                }
            }

            return seq;
        }
    }
}
