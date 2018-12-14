using System;

namespace CSP.Misc.Delegates.DelegateTest
{
    class MethodCollections
    {
        // Methods that take parameters but returns nothing

        public static void PrintText() => Console.WriteLine("Text printed w/ the help of Action");

        public static void PrintNumbers(int start, int target)
        {
            for (int i = start; i <= target; i++)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine();
        }

        public static void Print(string message) => Console.WriteLine(message);

        // Methods that take parameters and returns a value

        public static int Addition(int a, int b) => a + b;

        public static string DisplayAddition(int a, int b) => $"Addition of {a} and {b} is {a + b}";

        public static string ShowCompleteName(string firstName, string lastName) =>
            $"Your name is {firstName} {lastName}";

        public static int ShowNumber()
        {
            Random r = new Random();
            return r.Next();
        }
    }
}
