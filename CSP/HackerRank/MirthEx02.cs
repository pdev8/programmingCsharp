using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.HackerRank
{
    class MirthEx02
    {
        public static void Run()
        {
            Console.WriteLine(SumOfStrings("one two five ten"));
        }

        static int SumOfStrings(string stringNums)
        {
            string[] words = stringNums.ToLower().Split(' ');

            var numWord = new Dictionary<string, int>()
            {
                {"one", 1 },
                {"two", 2 },
                {"three", 3 },
                {"four", 4 },
                {"five", 5 },
                {"six", 6 },
                {"seven", 7 },
                {"eight", 8 },
                {"nine", 9 },
                {"ten", 10 }
            };

            int sum = 0;
            foreach (string word in words)
            {
                sum += numWord[word];
            }

            return sum;
        }
    }
}
