////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace CSP.AdventOCode
////{
////    public class ScottsWay
////    {
////        public static void Run()
////        {
////            var lines = new[]
////            {
////                "Step C must be finished before step A can begin.",
////                "Step C must be finished before step F can begin.",
////                "Step A must be finished before step B can begin.",
////                "Step A must be finished before step D can begin.",
////                "Step B must be finished before step E can begin.",
////                "Step D must be finished before step E can begin.",
////                "Step F must be finished before step E can begin."
////            };

////            Node root = null;
////            foreach (var line in GetNextRule(lines))
////            {
////                if (root == null)
////                {
////                    root = new Node
////                    {
////                        Name = line.Left,
////                        Children = new List<Node>
////                        {
////                            new Node
////                            {
////                                Name = line.Right,
////                                Children = new List<Node>()
////                            }
////                        }
////                    };
////                }
////                else
////                {
////                    var found = root.FindNode(line.Left);
////                    var child = root.FindNode(line.Right);

////                    if (child != null)
////                    {
////                        found.Children.Add(child);
////                    }
////                    else
////                    {
////                        found.Children.Add(new Node
////                        {
////                            Name = line.Right,
////                            Children = new List<Node>()
////                        });
////                    }
////                }
////            }

////            root.PrintChildren();
////        }

////        private static IEnumerable<Whatever> GetNextRule(string[] lines)
////        {
////            foreach (var line in lines)
////            {
////                yield return new Whatever
////                {
////                    Left = line[5],
////                    Right = line[36]
////                };
////            }
////        }
////    }

////    public class Whatever
////    {
////        public char Left { get; set; }
////        public char Right { get; set; }
////    }
////}
