using System;
using System.Threading.Tasks;

namespace CSP.Personal
{
    public class AsynchronousProgramming
    {
        public static void Run()
        {
            CallMethod();
        }

        public static async void CallMethod()
        {
            var task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            var count = 0;

            await Task.Run(() =>
            {
                for (var i = 0; i < 100; i++)
                {
                    Console.WriteLine(@" Method 1");
                    count++;
                }
            });

            return count;
        }

        public static void Method2()
        {
            for (var i = 0; i < 25; i++)
            {
                Console.WriteLine(@" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine($"Total count is {count}");
        }
    }
}
