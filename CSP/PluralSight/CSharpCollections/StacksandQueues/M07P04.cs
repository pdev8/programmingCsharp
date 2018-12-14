using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.StacksandQueues
{
    class M07P04
    {
        public static void Run()
        {
            Stack<string> books = new Stack<string>();

            books.Push("Programming WPF");
            books.Push("The Philosophy Book");
            books.Push("Heat and Thermodynamics");
            books.Push("Harry Potter and the Chamber of Secrets");

            Console.WriteLine("ALL BOOKS:");
            foreach (string title in books)
            {
                Console.WriteLine(title);
            }

            string topItem = books.Pop();
            Console.WriteLine($"\r\nTop item is {topItem}");

            Console.WriteLine("\r\nALL BOOKS after popping:");
            foreach (string title in books)
            {
                Console.WriteLine(title);
            }
        }
    }
}
