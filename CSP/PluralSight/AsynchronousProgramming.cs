using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSP.PluralSight
{
    public class AsynchronousProgramming
    {
        public static void Run()
        {
            var message = "Starting testing of async method.";
            Console.WriteLine(@"{0}", message);

            Console.WriteLine("What is your name?");

            AsyncMethod(Console.ReadLine());
        }

        public static async void AsyncMethod(string name)
        {
            var newName = await Task.Run(() =>
            {
                Thread.Sleep(2000);

                return name;
            });

            Console.WriteLine(@"Is your name {0}?", newName);

            // When using the await keyword, the continuation is executed on the calling context
            //await Task.Run(() =>
            //{
            //    Thread.Sleep(2000);
            //});

            //Console.WriteLine(@"Is your name {0}?", name);
        } 
    }
}
