using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Check to see if two provided string are anagrams of each other. One string
    /// is an anagram of another if it uses the same characters in the same quantity.
    /// Only consider characters, not spaces or punctuation. Consider capital letters
    /// to be the same as lower case
    /// --- Examples
    ///     anagrams('rail safety', 'fairy tales') ---> True
    ///     anagrams('RAIL! SAFETY!', 'fairy tales') --> True
    ///     anagrams('Hi there', 'Bye there') --> False
    /// 
    /// </summary>
    public class Anagrams
    {
        public static void Run()
        {
            Console.WriteLine(IsAnagram2("rail safety", "fairy tales"));
            Console.WriteLine(IsAnagram2("RAIL! SAFETY!", "fairy tales"));
            Console.WriteLine(IsAnagram2("Hi there", "Bye there"));
        }

        public static bool IsAnagram(string stringA, string stringB)
        {
            var word1 = new string(stringA.ToLower().Where(char.IsLetter).Distinct().ToArray());
            var word2 = new string(stringB.ToLower().Where(char.IsLetter).Distinct().ToArray());

            if (word1.Length != word2.Length)
            {
                return false;
            }

            var orderedWord1Dictionary = BuildCharacterMapping(word1, stringA);
            var orderedWord2Dictionary = BuildCharacterMapping(word2, stringB);

            for (var i = 0; i < orderedWord1Dictionary.Count(); i++)
            {
                if (orderedWord1Dictionary[0].Key != orderedWord2Dictionary[0].Key || orderedWord1Dictionary[0].Value != orderedWord2Dictionary[0].Value)
                {
                    return false;
                }
            }

            return true;
        }

        private static List<KeyValuePair<char, int>> BuildCharacterMapping(string word, string originalWord)
        {
            var wordDictionary = new Dictionary<char, int>();

            foreach (var character in word)
            {
                wordDictionary.Add(character, originalWord.Count(s => s == character));
            }

            return wordDictionary.OrderByDescending(s => s.Value).ThenByDescending(s => s.Key).ToList();
        }

        public static bool IsAnagram2(string stringA, string stringB)
        {
            var word1 = GetCleanWord(stringA);
            var word2 = GetCleanWord(stringB);

            if (word1.Length != word2.Length)
            {
                return false;
            }

            return !word1.Where((s, i) => s != word2[i]).Any();
        }

        private static string GetCleanWord(string word)
        {
            return new string(word.ToLower().Where(char.IsLetter).OrderBy(s => s).ToArray());
        }

        public static bool IsAnagram3(string stringA, string stringB)
        {
            return GetCleanWord(stringA) == GetCleanWord(stringB);
        }
    }
}
