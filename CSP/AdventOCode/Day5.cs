using System;

namespace CSP.AdventOCode
{
    public class Day5
    {
        public static void Run()
        {
            var polymer = "dabAcCaCBAcCcaDA";

            //var polymer = File.ReadAllText(@"C:\Users\ppauleee\Documents\Personal\AdventOCode\Polymer5.txt");
            //for (var i = 0; i < 50; i++)
            //{
            //    var reducedPolymer = ReducePolymer(polymer);
            //    polymer = reducedPolymer;
            //}

            Console.WriteLine(ReducePolymer(polymer));
            //Console.WriteLine(polymer);
        }

        private static string ReducePolymer(string polymer)
        {
            if (string.IsNullOrEmpty(polymer))
            {
                Console.WriteLine("Reached the end");
            }

            if (polymer.Length == 1)
            {
                return polymer;
            }

            var currentCharacter = char.ToUpper(polymer[0]);
            var nextCharacter = char.ToUpper(polymer[1]);

            if (currentCharacter.Equals(nextCharacter) && polymer[0] != polymer[1])
            {
                polymer = polymer.Substring(2);
            }

            return $"{polymer[0]}{ReducePolymer(polymer.Substring(1))}";
        }
    }
}