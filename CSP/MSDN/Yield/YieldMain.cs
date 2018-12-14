using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace CSP.MSDN.Yield
{
    public class YieldMain
    {
        static void Run()
        {
            foreach (int i in Power(2, 8))
            {
                Console.WriteLine($"{i}");
            }
        }

        static IEnumerable<int> Power(int number, int exponent)
        {
            var result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
