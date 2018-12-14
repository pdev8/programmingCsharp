using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch11Ex03
{
    class MainCopy
    {
        public static void Run()
        {
            Primes primesFrom2To1000 = new Primes(2, 1000);

            foreach (long i in primesFrom2To1000)
            {
                Console.Write($"{i} ");
            }
        }
    }
}