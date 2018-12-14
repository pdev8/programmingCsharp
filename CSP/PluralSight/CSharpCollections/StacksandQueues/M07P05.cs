using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.StacksandQueues
{
    class M07P05
    {
        public static void Run()
        {
            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Do the washing up");
            tasks.Enqueue("Finish the C# Collections Pluralsight course");
            tasks.Enqueue("Buy some chocolate");
            tasks.Enqueue("Buy some more chocolate");

            Console.WriteLine("\r\nALL TASKS:");
            foreach (string title in tasks)
            {
                Console.WriteLine(title);
            }

            string nextTask = tasks.Dequeue();
            Console.WriteLine($"\r\nNext task is {nextTask}");

            Console.WriteLine("\r\nALL TASKS:");
            foreach (string title in tasks)
            {
                Console.WriteLine(title);
            }
        }
    }
}
