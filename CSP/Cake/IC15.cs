using System;

namespace CSP.Cake
{
    class IC15
    {
        public static void Run()
        {
            Console.WriteLine($"The 9th Fibonacci number is: {Fibonacci(9)}");
            Console.WriteLine($"The 5th Fibonacci number is: {Fibonacci(5)}");
            Console.WriteLine($"The 3rd Fibonacci number is: {Fibonacci(3)}");
        }

        static int Fibonacci(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Index was negative. No such thing as a negative index in a series.");
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }

            // We'll be building the fibonacci series from the bottom up.
            // So we'll need to track the previous 2 numbers at each step.
            int prevPrev = 0; // 0th fibonacci
            int prev = 1; // 1st fibonacci
            int current = 0; // Declare and initialize current

            for (int i = 1; i < n; i++)
            {
                // Iteration 1: current = 2nd fibonacci
                // Iteration 2: current = 3rd fibonacci
                // Iteration 3: current = 4th fibonacci
                current = prev + prevPrev;
                prevPrev = prev;
                prev = current;
            }

            return current;
        }
    }
}
