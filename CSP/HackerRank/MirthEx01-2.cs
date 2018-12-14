using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.HackerRank
{
    class MirthEx01_2
    {
        public static void Run()
        {
            //DiffBetweenTwoStrings("health", "qsi"); // h
            //DiffBetweenTwoStrings("sanjeewa", "ashish"); // e, h
            //DiffBetweenTwoStrings("iwFpifCY", "vNnevoWFxqpfe"); // e, i, n, v
            DiffBetweenTwoStrings("January", "February");
        }

        /// <summary>
        /// Given two strings, identify the character(s) that has the largest difference between
        /// number of occurrences in the two strings. Return an array of strings (of characters)
        /// in alphabetical orders.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>Characters in a string array</returns>
        static string[] DiffBetweenTwoStrings(string first, string second)
        {
            // Collection of characters (key) and number of unique letters in each word (value)
            var strDictionary = new Dictionary<char, Tuple<int, int>>();
            // Catch cases where there are capital letters
            first = first.Trim().ToLower();
            second = second.Trim().ToLower();

            int count = 0;
            for (int i = 0; i < first.Length; i++)
            {
                // Traverse through each letter in the first word
                char letter = first[i];
                // If the letter is not in the dictionary, add it and store a count of 1 for that letter
                if (!strDictionary.ContainsKey(letter))
                    strDictionary.Add(letter, Tuple.Create(1, 0));
                else
                {
                    // Get the number of characters so far
                    count = strDictionary[letter].Item1;
                    // Add it because the character exists in the dictonary
                    count++;
                    // Update the count of the characters
                    strDictionary[letter] = Tuple.Create(count, 0);
                }
            }

            for (int j = 0; j < second.Length; j++)
            {
                // Traverse through each letter in the second word
                char letter = second[j];
                if (!strDictionary.ContainsKey(letter))
                    strDictionary.Add(letter, Tuple.Create(0, 1));
                else
                {
                    int firstCount = strDictionary[letter].Item1;
                    count = strDictionary[letter].Item2;
                    count++;
                    strDictionary[letter] = Tuple.Create(firstCount, count);
                }
            }

            // Sort the dictionary according to the max number of distinct letters
            var sortedDictionary = strDictionary.OrderByDescending(x => Math.Abs(x.Value.Item1 - x.Value.Item2));

            // Store the greatest difference of the first element
            int maxCount = Math.Abs(sortedDictionary.First().Value.Item1 - sortedDictionary.First().Value.Item2);

            // Store the letters whose value equals the greatest difference
            var charArr = sortedDictionary
                // For each element whose difference equals the max count
                .Where(x => Math.Abs(x.Value.Item1 - x.Value.Item2) == maxCount)
                // Select each character and cast it as a string
                .Select(x => x.Key.ToString())
                // Sort it by each character
                .OrderBy(x => x)
                // Put characters into a string array
                .ToArray();

            Console.WriteLine($"Count of distinct letter for the following words: {first}, {second}");

            foreach (var str in strDictionary)
            {
                Console.WriteLine($"{str.Key}: {str.Value.Item1}  {str.Value.Item2}");
            }

            string s = string.Join(", ", charArr);
            Console.WriteLine($"These character(s) have the greatest difference: {s}\n");

            // Return the string array of characters
            return charArr;
        }
    }
}
