using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CSP.Misc
{
    class Test1
    {
        public static void Run()
        {
            foreach(int num in OddNumbers(1, 59))
            {
                Console.WriteLine(num);
            }
        }

        static int[] OddNumbers(int l, int r) => Enumerable.Range(l, r - l + 1).Where(x => x % 2 != 0).ToArray();
    }
}
