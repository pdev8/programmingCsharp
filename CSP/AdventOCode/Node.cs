using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSP.AdventOCode
{
    ////public class Node
    ////{
    ////    public char Name { get; set; }

    ////    public List<Node> Children { get; set; }

    ////    //public bool Printed { get; set; }

    ////    public Node FindNode(char name)
    ////    {
    ////        if (name == this.Name)
    ////        {
    ////            return this;
    ////        }

    ////        foreach (var child in this.Children)
    ////        {
    ////            if (child.FindNode(name) != null)
    ////            {
    ////                return child.FindNode(name);
    ////            };
    ////        }

    ////        return null;
    ////    }

    ////    public void PrintChildren()
    ////    {
    ////        //if (this.Printed)
    ////        //{
    ////        //    return;
    ////        //}

    ////        //this.Printed = true;

    ////        Console.Write(this.Name);

    ////        foreach (var child in this.Children.OrderBy(s => s.Name))
    ////        {
    ////            child.PrintChildren();
    ////        }
    ////    }
    ////}
    ///

    // _______________________________________________________________________

    public class Node
    {
        public Node(char n)
        {
            this.Name = n;
        }
        public char Name { get; set; }
        public List<Node> Children { get; set; } = new List<Node>();
        public List<Node> Parents { get; set; } = new List<Node>();
        public Node FindNode(char name)
        {
            if (this.Name == name)
            {
                return this;
            }

            foreach (var item in Children)
            {
                var found = item.FindNode(name);
                if (found != null)
                {
                    return found;
                }
            }
            return null;
        }

        public void AddChild(Node node)
        {
            this.Children.Add(node);
        }
        public void AddParent(Node node)
        {
            this.Parents.Add(node);
        }
        public void FlattenNodes(List<Node> nodes)
        {
            nodes.Remove(this);
            nodes.Add(this);
            foreach (var item in Children.OrderBy(a => a.Name))
            {
                item.FlattenNodes(nodes);
            }
        }
    }

    public class OutNodes
    {
        public char Left;
        public char Right;
    }

    public class Bob
    {
        public static void Run()
        {
            //var lines = new string[]
            //{
            //    "Step C must be finished before step A can begin.",
            //    "Step C must be finished before step F can begin.",
            //    "Step A must be finished before step B can begin.",
            //    "Step A must be finished before step D can begin.",
            //    "Step B must be finished before step E can begin.",
            //    "Step D must be finished before step E can begin.",
            //    "Step F must be finished before step E can begin."
            //};

            var path = @"C:\Users\ppauleee\Documents\Personal\AdventOCode\Instructions.txt";
            var lines = File.ReadAllLines(path);


            var pendingnodes = new List<Node>();
            foreach (var item in GetNodes(lines))
            {
                if (!pendingnodes.Any(a => a.Name == item.Left))
                {
                    pendingnodes.Add(new Node(item.Left));
                }
                if (!pendingnodes.Any(a => a.Name == item.Right))
                {
                    pendingnodes.Add(new Node(item.Right));
                }
            }


            foreach (var item in GetNodes(lines))
            {
                var foundleft = pendingnodes.FirstOrDefault(a => a.Name == item.Left);
                var foundright = pendingnodes.FirstOrDefault(a => a.Name == item.Right);
                foundleft.AddChild(foundright);
                foundright.AddParent(foundleft);
            }
            var root = pendingnodes.FirstOrDefault(a => !a.Parents.Any());
            var flattened = new List<Node>();
            root.FlattenNodes(flattened);
            foreach (var item in flattened)
            {
                Console.Write(item.Name);
            }
            Console.ReadKey();
        }

        public static IEnumerable<OutNodes> GetNodes(string[] lines)
        {
            foreach (var item in lines)
            {
                yield return new OutNodes
                {
                    Left = item[5],
                    Right = item[36]
                };
            }
        }
    }
}