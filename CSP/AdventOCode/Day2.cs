using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Unity.Interception.Utilities;

namespace CSP.AdventOCode
{
    public class Day2
    {
        public static void Run()
        {
            var lines = GetLinesFromText();

            SolveDay2Part1(lines);
            SolveDay2Part2(lines);
        }

        private static string[] GetLinesFromText()
        {
            var path = @"C:\Users\ppauleee\Documents\Personal\AdventOCode\RepeatingCharacters2.txt";
            var lines = File.ReadAllLines(path);

            return lines;
        }

        private static void SolveDay2Part1(IEnumerable<string> lines)
        {
            var both = 0;
            var two = 0;
            var three = 0;
            foreach (var line in lines)
            {
                var grouped = line.GroupBy(s => s).Select(s => new { Char = s.Key, Count = s.Count() }).ToList();

                if (grouped.Any(s => s.Count == 2) && grouped.Any(s => s.Count == 3))
                {
                    both++;
                }
                else if (grouped.Any(s => s.Count == 2))
                {
                    two++;
                }
                else if (grouped.Any(s => s.Count == 3))
                {
                    three++;
                }
            }

            var total = (both + two) * (both + three);

            Console.WriteLine($"The total is {total}");

        }

        private static void SolveDay2Part2(IEnumerable<string> lines)
        {
            lines = lines.ToList();

            var firstWord = string.Empty;
            var secondWord = string.Empty;

            var currentIndex = 0;
            var current = lines.ToList()[currentIndex];

            restart:
            foreach (var line in lines.Select((item, k) => new { item, k }))
            {
                var notMatching = 0;

                current.Select((character, i) => new
                {
                    Character = character,
                    Index = i
                }).ForEach(s =>
                {
                    if (s.Character != line.item[s.Index])
                    {
                        notMatching++;
                        firstWord = current;
                        secondWord = line.item;
                    }
                });

                if (line.k == lines.Count() - 1)
                {
                    currentIndex++;
                    current = lines.ToList()[currentIndex];
                    goto restart;
                }

                if (notMatching == 1)
                {
                    Console.WriteLine($"First word: {firstWord} | Second word: {secondWord}");
                    Console.Write($"The different charcters are: {new string(firstWord.Except(secondWord).ToArray())}");
                    break;
                }
            }
        }
    }
}