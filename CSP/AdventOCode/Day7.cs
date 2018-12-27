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
            ////var path = @"C:\Users\ppauleee\Documents\Personal\AdventOCode\Instructions.txt";
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

        private static string CalculateLastStep(string[] lines)
        {
            var correctOrder = string.Empty;

            var firstLine = lines.First();
            var parentNode = firstLine[5];
            var childNode = firstLine[36];

            var node = new Node
            {
                Letter = childNode,
                Parents = new List<Node>
                {
                    new Node
                    {
                        Letter = parentNode,
                        Parents = new List<Node>()
                    }
                }
            };

            foreach (var line in lines)
            {

            }

            return correctOrder;
        }

        private class Node
        {
            public char Letter { get; set; }

            public List<Node> Parents { get; set; }

            public Node()
            {
                this.Parents = new List<Node>();
            }

            public Node FindNode(char letter)
            {
                if (letter == this.Letter)
                {
                    return this;
                }

                foreach (var parent in this.Parents)
                {
                    var node = parent.FindNode(letter);

                    if (node == null)
                    {
                        this.Parents.Add(new Node
                        {
                            Letter = letter,
                            Parents = new List<Node>()
                        });
                    }
                }

                return null;
            }
        }
    }
}