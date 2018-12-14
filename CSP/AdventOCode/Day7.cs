using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.AdventOCode
{
    public class Day7
    {
        private readonly IFileReader fileReader;

        public Day7(
            IFileReader fileReader)
        {
            this.fileReader = fileReader;
        }

        public void Run()
        {
            var path = @"C:\Users\ppauleee\Documents\Personal\AdventOCode\Instructions.txt";
            //var lines = this.fileReader.ReadLinesFromTextFile(path);

            var lines = new[]
            {
                "Step C must be finished before step A can begin.",
                "Step C must be finished before step F can begin.",
                "Step A must be finished before step B can begin.",
                "Step A must be finished before step D can begin.",
                "Step B must be finished before step E can begin.",
                "Step D must be finished before step E can begin.",
                "Step F must be finished before step E can begin."
            };

            CalculateLastStep(lines);
        }

        private void CalculateLastStep(string[] lines)
        {
            var firstLetter = string.Empty;
            var secondLetter = string.Empty;

            var instructionOrder = new List<string>();
            foreach (var line in lines)
            {
                var words = line.Split(' ');

                var firstIndex = Array.IndexOf(words, words.First(s => string.Equals(s, "step", StringComparison.OrdinalIgnoreCase)));
                firstLetter = words[firstIndex + 1];

                var secondIndex = Array.IndexOf(words, words.Last(s => string.Equals(s, "step", StringComparison.OrdinalIgnoreCase)));
                secondLetter = words[secondIndex + 1];

                if (!instructionOrder.Any())
                {
                    instructionOrder.Add(firstLetter);
                    instructionOrder.Add(secondLetter);
                }
                else if (!instructionOrder.Contains(secondLetter))
                {
                    instructionOrder.Add(secondLetter);
                }
                else if (instructionOrder.Contains(firstLetter) && !instructionOrder.Contains(secondLetter))
                {
                    instructionOrder.Add(secondLetter);
                }
            }
        }
    }
}
