using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.StudentCodeReview.StackExample
{
    class StackMain
    {
        public static void Run()
        {
            var numbers = new Stack<int>();

            for (int i = 1; i <= 5; i++)
            {
                numbers.Push(i);
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
