using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP
{
    public static class HackerRank2
    {
        public static void Run()
        {
            var total = KSub(15, new List<int>
            {
                14, 10, 9, 7, 4, 3, 2, 1
            });

            Console.WriteLine(total);
        }

        public static void CustomSort(List<int> numbers)
        {
            var numberDictionary = new Dictionary<int, int>();

            foreach (var num in numbers)
            {
                if (!numberDictionary.ContainsKey(num))
                {
                    numberDictionary.Add(num, 1);
                }
                else
                {
                    var count = numberDictionary.First(s => s.Key == num).Value;
                    numberDictionary[num] = ++count;
                }
            }

            foreach (var num in numberDictionary.OrderBy(s => s.Value))
            {
                for (var i = 0; i < num.Value; i++)
                {
                    Console.WriteLine($"{num.Key}");
                }
            }
        }

        public static long KSub(int k, List<int> nums)
        {
            var total = new List<int>();
            var count = 0;

            if (nums.Count == 0)
            {
                return 0;
            }

            foreach (var num in nums.OrderByDescending(s => s))
            {
                total.Add(num);

                if (total.Sum() > k)
                {
                    total.Remove(num);
                    continue;
                }

                if (total.Sum() % k == 0)
                {
                    count++;
                }
            }

            nums.RemoveAt(0);

            return count + KSub(k, nums);
        }

        public static void MissingNumber(string s, string t)
        {
            var missingDictionary = new List<string>();

            var sDictionary = s.Split(' ');
            var tDictionary = t.Split(' ');

            foreach (var word1 in sDictionary)
            {
                if (!tDictionary.Any(r => r.Equals(word1)))
                {
                    missingDictionary.Add(word1);
                }
            }

            foreach (var word in missingDictionary)
            {
                Console.WriteLine(word);
            }
        }
    }
}
