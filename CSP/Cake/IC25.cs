using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    /// <summary>
    /// Write a method KthToLastNode() that takes an integer k and the headNode of a
    /// singly-linked list, and returns the kth to last node in the list.
    /// </summary>
    class IC25
    {
        public static void Run()
        {
            LinkedListNode3 a = new LinkedListNode3(1);
            LinkedListNode3 b = new LinkedListNode3(2);
            LinkedListNode3 c = new LinkedListNode3(3);
            LinkedListNode3 d = new LinkedListNode3(4);
            LinkedListNode3 e = new LinkedListNode3(5);

            a.Next = b;
            b.Next = c;
            c.Next = d;
            d.Next = e;

            LinkedListNode3 nodeToFind = KthToLastNode(2, a);

            Console.WriteLine("List of node values.\n");

            Console.WriteLine($"Value of node a: {a.Value}");
            Console.WriteLine($"Value of node b: {b.Value}");
            Console.WriteLine($"Value of node c: {c.Value}");
            Console.WriteLine($"Value of node d: {d.Value}");
            Console.WriteLine($"Value of node e: {e.Value}");

            Console.WriteLine($"\nThe value of the 2nd to last node is: {nodeToFind.Value}");
        }

        static LinkedListNode3 KthToLastNode(int k, LinkedListNode3 headNode)
        {
            if (k < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(k), $"Impossible to find less than " +
                                                                 $"first to last node: {k}");
            }

            int listLength = 1;
            LinkedListNode3 currentNode = headNode;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                listLength++;
            }

            if (k > listLength)
            {
                throw new ArgumentOutOfRangeException(nameof(k), $"k is larger than the length " +
                                                                 $"of the linked list: {k}");
            }

            int howFarToGo = listLength - k;

            currentNode = headNode;
            for (int i = 0; i < howFarToGo; i++)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }
    }

    class LinkedListNode3
    {
        public int Value { get; set; }
        public LinkedListNode3 Next { get; set; }

        public LinkedListNode3(int value)
        {
            Value = value;
        }
    }
}
