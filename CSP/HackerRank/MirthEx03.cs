using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.HackerRank
{
    class MirthEx03
    {
        public static void Run()
        {
            ReplaceSpace(new[] { "N", "e", "e", "d", " ", "s", "o", "m", "e", " ", "s", "p", "a", "c", "e", " ", " ", " ", " " }); // 19
            // Need%20some%20space
            ReplaceSpace(new[] { " ", "M", "u", "s", "t", " ", "f", "i", "n", "i", "s", "h", " " }); // 13
            // Must%20finish
            ReplaceSpace(new[] { "T", "h", "i", "s", " ", " ", "i", "s", " ", "a", " ", "t", "e", "s", "t", " ", " ", " ", " ", " ", " ", " ", " " }); // 23
            // This%20%20is%20a%20test
            ReplaceSpace(new[] { "A", " ", "B", " ", " " });
        }

        static void ReplaceSpace(string[] str)
        {
            string word = String.Join("", str).Trim().Replace(" ", "%20");
            Console.WriteLine(word);
            Console.WriteLine(str.Length);
        }
    }
}
