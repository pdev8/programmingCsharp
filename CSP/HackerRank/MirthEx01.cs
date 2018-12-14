using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSP.HackerRank
{
    class MirthEx01
    {
        public static void Run()
        {
            DiffBetweenTwoStrings("Sanjeewa", "ashish");
            DiffBetweenTwoStrings("health", "qsi");
            DiffBetweenTwoStrings("eiwFeifCY", "vNnvoWFxqpf");
            //DiffBetweenTwoStrings("", "");
        }

        static void DiffBetweenTwoStrings(string first, string second)
        {
            Dictionary<char, Tuple<int, int>> records = new Dictionary<char, Tuple<int, int>>();
            first = first.Trim().ToLower();
            second = second.Trim().ToLower();

            if (first.Length == 0 && second.Length == 0)
                throw new ArgumentException("Blank strings");

            int count;
            // Keep track of number of letters in first string
            for (int i = 0; i < first.Length; i++)
            {
                if (!records.ContainsKey(first[i]))
                {
                    records.Add(first[i], Tuple.Create(1, 0));
                }
                else
                {
                    // If the key exists in the dictionary
                    count = records[first[i]].Item1;
                    count++;
                    records[first[i]] = Tuple.Create(count, 0);
                }
            }

            // Keep track of number of letters in second string
            for (int j = 0; j < second.Length; j++)
            {
                if (!records.ContainsKey(second[j]))
                {
                    records.Add(second[j], Tuple.Create(0, 1));
                }
                else
                {
                    int firstCount = records[second[j]].Item1;
                    count = records[second[j]].Item2;
                    count++;
                    records[second[j]] = Tuple.Create(firstCount, count);
                }
            }

            // Sorts the dictionary by the difference of its values
            var newRec = records.OrderByDescending(x => Math.Abs(x.Value.Item1 - x.Value.Item2));
            // Find the greatest difference
            int max = Math.Abs(newRec.First().Value.Item1 - newRec.First().Value.Item2);
            // Check which keys have the same value as the max difference
            var charArray = newRec.Where(x => Math.Abs(x.Value.Item1 - x.Value.Item2) == max).Select(c => c.Key).ToArray();

            Console.WriteLine("Count of distinct letters for words: {0}, {1}", first, second);
            foreach (var record in records)
            {
                Console.WriteLine($"{record.Key} {record.Value.Item1} {record.Value.Item2}");
            }

            Console.WriteLine("These characters have the greatest difference:");
            string test = String.Join(", ", charArray);
            Console.WriteLine(test + "\n");
        }
    }
}
