using System;

// Variable Scope in Lambda Expressions
namespace CSP.Misc
{
    delegate bool D();

    delegate bool D2(int i);

    class LambdaExpression
    {
        private static D del;
        private static D2 del2;

        public static void TestMethod(int input)
        {
            int j = 0;

            // Initialize the delegate w/ lambda expressions
            // Note access to 2 outher variables
            
            // del will be invoked w/in this method
            del = () =>
            {
                j = 10;
                return j > input;
            };

            // del2 will be invoked after TestMethod goes out of scope 
            del2 = (x) => { return x == j; };

            // Demonstrate value of j:
            // Output: j = 0
            // The delegate has not been invoked yet
            Console.WriteLine($"j = {j}");      // Invoke the delegate
            bool boolResult = del();

            Console.WriteLine($"j = {j}. b = {boolResult}");
        }

        public static void Run()
        {
            TestMethod(5);

            // Prove that del2 still has a copy of local variables j from TestMethod
            bool result = del2(10);

            // Output: True
            Console.WriteLine(result);
        }
    }
}
