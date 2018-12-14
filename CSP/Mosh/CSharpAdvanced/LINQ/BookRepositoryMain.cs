using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.LINQ
{
    class BookRepositoryMain
    {
        public static void Run()
        {
            var books = new BookRepository().GetBooks();

            // LINQ Query Operators
            var cheaperBooks = 
                from b in books // Always starts w/ a from
                where b.Price < 10
                orderby b.Title
                select b.Title; // Always ends w/ a select

            // LINQ Extension Methods - more powerful
            var cheapBooks = books
                .Where(b => b.Price < 10)
                .OrderBy(b => b.Price)
                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }

            var aspBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
        }
    }
}
