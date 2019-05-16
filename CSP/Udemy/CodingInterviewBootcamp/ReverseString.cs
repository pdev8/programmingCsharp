using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace CSP.Udemy.CodingInterviewBootcamp
{
    /// <summary>
    /// 
    /// --- Directions
    /// Given a string, return a new string w/ the reversed order of characters
    ///
    /// --- Examples
    ///   reverse('apple') === 'elppa'
    ///   reverse('hello') === 'olleh'
    ///   reverse('Greetings!') === '!sgniteerG'
    /// 
    /// </summary>
    public class ReverseString
    {
        public static void Run()
        {
        }

        public static string Reverse1(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public static string Reverse2(string str)
        {
            return new string(str.Select((s, index) => str.ElementAt(str.Length - ++index)).ToArray());
        }

        public static string Reverse3(string str)
        {
            var reversed = string.Empty;

            foreach (var character in str)
            {
                reversed = character + reversed;
            }

            return reversed;
        }

        public static string Reverse4(string str)
        {
            return string.Join("", str.ToCharArray().Reverse());
        }

        public static string Reverse5(string str)
        {
            if (str.Length == 1)
            {
                return str;
            }

            return str.LastOrDefault() + Reverse5(str.Substring(0, str.Length - 1));
        }
    }
}