using System;
using System.Linq;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Write a function that returns the number of vowels used in a string.
    /// Vowels are the characters 'a', 'e', 'i', 'o', 'u'.
    /// --- Examples
    ///     vowels('Hi There!') --> 3
    ///     vowels('Why do you ask?') --> 4
    ///     vowels('Why?') --> 0
    /// 
    /// </summary>
    public class Vowels
    {
        public static void Run()
        {
            Console.WriteLine($"Number of vowels in 'Hi There!': {CountVowels("Hi There!")}");
            Console.WriteLine($"Number of vowels in 'Why do you ask?': {CountVowels("Why do you ask?")}");
            Console.WriteLine($"Number of vowels in 'Why?': {CountVowels("Why?")}");
        }

        public static int CountVowels(string str)
        {
            var validCharacters = new[] {'a', 'e', 'i', 'o', 'u'};

            return str.ToLower().Count(s => validCharacters.Any(t => s == t));
        }
    }
}