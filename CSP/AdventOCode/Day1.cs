using System;
using System.IO;
using System.Linq;

namespace CSP.AdventOCode
{
    public class Day1
    {
        public static void Run()
        {
            var intervals = ReadIntervalsFromFile();

            var intervalTotal = intervals.Sum(Convert.ToInt32);

            Console.WriteLine($"The interval frequency total is {intervalTotal}");
        }

        public static string[] ReadIntervalsFromFile()
        {
            var path = @"C:\Users\ppauleee\Documents\Personal\AdventOCode\Intervals1.txt";
            var lines = File.ReadAllLines(path);

            return lines;
        }
    }
}