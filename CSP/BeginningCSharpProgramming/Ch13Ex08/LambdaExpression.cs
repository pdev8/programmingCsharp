using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch13Ex08
{
    delegate int TwoIntegerOperationDelegate(int paramA, int paramB);

    class LambdaExpression
    {
        public static void Run()
        {
            Console.WriteLine("f(a, b) = a + b");
            DelegateCaller.PerformOperations((paramA, paramB) => paramA + paramB);
            Console.WriteLine();

            Console.WriteLine("f(a, b) = a * b");
            DelegateCaller.PerformOperations((paramA, paramB) => paramA * paramB);
            Console.WriteLine();

            Console.WriteLine("f(a, b) = (a - b) % b");
            DelegateCaller.PerformOperations((paramA, paramB) => (paramA - paramB) % paramB);
            Console.WriteLine();
        }
    }

    class DelegateCaller
    {
        public static void PerformOperations(TwoIntegerOperationDelegate del)
        {
            for (int paramAVal = 1; paramAVal <= 5; paramAVal++)
            {
                for (int paramBVal = 1; paramBVal <= 5; paramBVal++)
                {
                    int delCallResult = del(paramAVal, paramBVal);
                    Console.Write($"f({paramAVal}, {paramBVal}={delCallResult}");

                    if (paramBVal != 5)
                        Console.WriteLine(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
