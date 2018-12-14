using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpBeginner
{
    public static class S05Lec44
    {
        public static void Run()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }

            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
