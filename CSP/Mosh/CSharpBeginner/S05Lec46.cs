using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpBeginner
{
    public static class S05Lec46
    {
        public static void Run()
        {
            while (true)
            {
                Console.Write("Type your name: ");
                string input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input)) {
                    Console.WriteLine($"@Echo: {input}");
                    continue;
                }

                break;
            }
        }
    }
}
