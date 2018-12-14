using System;

namespace CSP.Personal
{
    // Essentially, when creating an object (or initializing a struct) it zeros the memory
    // (or in the case of a non-default struct ctor, forces you to manually initialize everything).
    // However, variables are so common (in every method) that it doesn't want the overhead of
    // having to zero the stack all the time. It instead forces you to indicate the initial value

    public class ForLoop
    {
        // Fields automatically default to 0/false/null
        public static int total;

        public static void Run()
        {
            // Variables are not defaulted, and must have "definite assignment" before they are used
            //int j;

            for (var i = 0; i < 6; i++)
            {
                total += i;
            }

            Console.WriteLine($"Total: {total}");
        }
    }
}