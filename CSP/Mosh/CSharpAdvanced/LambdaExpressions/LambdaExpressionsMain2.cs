using System;

namespace CSP.Mosh.CSharpAdvanced.LambdaExpressions
{
    public class LambdaExpressionsMain2
    {
        public static void Run()
        {
            Func<int, int> square = number => number * number;

            Console.WriteLine(square?.Invoke(5));
        }
    }
}
