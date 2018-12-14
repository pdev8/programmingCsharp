using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Cake
{
    class IC24
    {
        public static void Run()
        {
            LinkedList<LinkedListNode2> myLinkedList = new LinkedList<LinkedListNode2>();
            myLinkedList.AddLast(new LinkedListNode2(1));
            myLinkedList.AddLast(new LinkedListNode2(2));
            myLinkedList.AddLast(new LinkedListNode2(3));

            foreach (LinkedListNode2 node in myLinkedList)
            {
                Console.WriteLine(node.Value);
            }

            Reverse(myLinkedList.First.Value);
            Console.WriteLine(Reverse(myLinkedList.First.Value).Next.Value);

            foreach (LinkedListNode2 node in myLinkedList)
            {
                Console.WriteLine(node.Value);
            }
        }

        static LinkedListNode2 Reverse(LinkedListNode2 headOfList)
        {
            LinkedListNode2 current = headOfList;
            LinkedListNode2 previous = null;
            LinkedListNode2 nextNode = null;

            while (current != null)
            {
                nextNode = current.Next;
                current.Next = previous;

                previous = current;
                current = nextNode;
            }

            return previous;
        }
    }

    class LinkedListNode2
    {
        public int Value { get; set; }
        public LinkedListNode2 Next { get; set; }

        public LinkedListNode2(int value)
        {
            Value = value;
        }
    }
}
