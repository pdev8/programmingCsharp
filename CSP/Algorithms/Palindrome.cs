using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Given a string, return true if the string is a palindrome or false it
    /// it is not. Palindromes are strings that form the same word if it is
    /// reversed. *DO* included spaces and punctuation in determining if the
    /// string is a palindrome
    /// --- Examples:
    ///     palindrome("abba") === true
    ///     palindrome("abcdefg") === false
    /// 
    /// </summary>
    public class Palindrome
    {
        public static void Run()
        {
            Console.WriteLine("IsPalindrome");
            Console.WriteLine(IsPalindrome("abba"));
            Console.WriteLine(IsPalindrome("abcdefg"));
            Console.WriteLine(IsPalindrome("racecar"));
            Console.WriteLine(IsPalindrome("spaghetti"));

            Console.WriteLine("IsPalindrome2");
            Console.WriteLine(IsPalindrome2("racecar"));
        }

        public static bool IsPalindrome(string str)
        {
            var reversed = new string(str.Reverse().ToArray());

            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);

            ////foreach(var character in str.Select((value, index) => new {value, index}))
            ////{
            ////    if (character.value != reversed[character.index])
            ////    {
            ////        return false;
            ////    }
            ////}

            ////return true;
        }

        public static bool IsPalindrome2(string str)
        {
            return str.Select((value, index) => new {value, index}).All(character => character.value == str[str.Length - character.index - 1]);
        }
    }
}