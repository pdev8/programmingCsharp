using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    class _6Printer
    {
        // What is the output of the program below?

        delegate void Printer();

        public static void Run()
        {
            List<Printer> printers = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
                // The program will output the number ten 10 times
            }

            foreach (var printer in printers)
            {
                printer();
            }
        }
        // Toptal's Explanation
        // The delegate is added in the for loop and "pointer" to i is stored,
        // rather than the value itself. Therefore, after we exit the loop, the
        // variable i has been set to 10, so by the time each delegate is invoked,
        // the value passed to all of them is 10
    }
}
