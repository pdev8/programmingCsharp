using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom
{
    class Test2
    {
        public static void Run()
        {
            Console.WriteLine(IsPalindrome("palindrome"));
            Console.WriteLine(IsPalindrome("racecar"));

            Console.WriteLine("racecat".Reverse());
            Console.WriteLine("racecat".Reverse().ToArray());
            foreach (char c in "racecat".Reverse().ToArray())
            {
                Console.WriteLine(c);
            }
        }

        static bool IsPalindrome(string testCase) => testCase == new string(testCase.Reverse().ToArray());
    }
}
