using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    class IC22
    {
        public static void Run()
        {
            LinkedListNode a = new LinkedListNode(1);
            LinkedListNode b = new LinkedListNode(2);
            LinkedListNode c = new LinkedListNode(3);

            a.Next = b;
            b.Next = c;

            Console.WriteLine("Original Linked List Node Values");
            Console.WriteLine($"Node a: {a.Value}");
            Console.WriteLine($"Node b: {b.Value}");
            Console.WriteLine($"Node c: {c.Value}");

            DeleteNode(b);

            Console.WriteLine("After deleting the middle node");
            Console.WriteLine($"Node a: {a.Value}"); // 1
            Console.WriteLine($"Node b: {b.Value}"); // 3

            // Potential side-effects
            // 1. Any references to the input node have now effectively been reassigned to its Next
            // node.
            // In our example, we "deleted" the node assigned to the variable b, but in actuality we
            // just gave it a new value (2) and a new Next! If we had another pointer to b somewhere
            // else in our code and we were assuming it still had its old value (8), that could cause
            // bugs.

            // 2. If there are pointers to the input node's original next node, those pointers now
            // point to a "dangling" node (a node that is no longer reachable by walking down our list).
            // In our example above, c is now dangling. If we changed c, we'd never encounter that new
            // value by walking down our list from the head to the tail.
        }

        static void DeleteNode(LinkedListNode nodeToDelete)
        {
            LinkedListNode nextNode = nodeToDelete.Next;

            if (nextNode != null)
            {
                nodeToDelete.Value = nextNode.Value;
                nodeToDelete.Next = nextNode.Next;
            }
            else
            {
                throw new InvalidOperationException("Can't delete the last node with this technique!");
            }
        }
    }

    class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }
    }
}
