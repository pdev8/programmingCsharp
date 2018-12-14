using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.StudentCodeReview.StopWatchExample
{
    class StopWatchMain
    {
        public static void Run()
        {
            var stopWatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopWatch.Start();

                Thread.Sleep(1000);

                stopWatch.Stop();

                Console.WriteLine($"Duration: {stopWatch.GetInterval()}");
                Console.WriteLine("Press Enter to run the stopwatch one more time.");
                Console.ReadLine();
            }
        }
    }
}
