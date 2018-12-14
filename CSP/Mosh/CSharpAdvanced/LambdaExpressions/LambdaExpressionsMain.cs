using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.LambdaExpressions
{
    class LambdaExpressionsMain
    {
        public static void Run()
        {
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            #region Test Code
            // args => expression

            // No arguments
            // () => ...

            // Single argument
            // x => ...

            // Multiple arguments
            // (x, y, z) => ...

            //Func<int, int> square = number => number * number;

            //const int factor = 5;

            //Func<int, int> result = n => n * factor; 
            #endregion
        }

        // Predicate
        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}
