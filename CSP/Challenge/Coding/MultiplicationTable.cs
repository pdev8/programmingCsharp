using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Challenge.Coding
{
    class MultiplicationTable
    {
        public static void Run()
        {
            DisplayTable();
        }

        static void DisplayTable()
        {
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
