using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Given a string, return the character that is most commonly used in
    /// the string.
    /// --- Examples
    ///     maxChar("abccccccd") === "c"
    ///     maxChar("apple 1231111") === "1"
    /// 
    /// </summary>
    public class MaxChars
    {
        public static void Run()
        {
            Console.WriteLine(FindMaxChar("abccccccd"));
            Console.WriteLine(FindMaxChar("apple 1231111"));
            Console.WriteLine(FindMaxChar("abcdefghijklmnopqrstuvwxyzi"));
        }

        public static char FindMaxChar(string str)
        {
            var dictionary = new Dictionary<char, int>();

            foreach (var character in str.Distinct())
            {
                if (!dictionary.ContainsKey(character))
                {
                    dictionary.Add(character, str.Count(s => s == character));
                }
            }

            return dictionary.OrderByDescending((character) => character.Value).FirstOrDefault().Key;
        }
    }
}
