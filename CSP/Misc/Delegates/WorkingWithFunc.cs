using System;

namespace CSP.Misc.Delegates
{
    public class WorkingWithFunc
    {
        public static void Run()
        {
            // Create a Func that has 1 parameter and 1 return value.
            // ... Parameter is an integer, result value is a string
            Func<int, string> func1 = (x) => string.Format($"string = {x}");

            // Func instance w/ two parameters and one result.
            // ... Receives bool and int, returns string
            Func<bool, int, string> func2 = (b, x) => string.Format($"string = {b} and {x}");

            // Func instance that has no parameters and one result value.
            Func<double> func3 = () => Math.PI / 2;

            // Call the Invoke instance method on the anonymous functions.
            Console.WriteLine(func1.Invoke(5));
            Console.WriteLine(func2.Invoke(true, 10));
            Console.WriteLine(func3.Invoke());
        }
    }
}