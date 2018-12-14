using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.LinkedLists
{
    class LinkedListExample
    {
        public class List
        {
            public class Node
            {
                public object NodeContent;
                public Node Next;
            }

            private int size;
            private Node head;
            private Node current;

            public int Count => size;

            public List()
            {
                size = 0;
                head = null;
            }

            public void Add(object content)
            {
                size++;

                Node node = new Node()
                {
                    NodeContent = content
                };

                if (head == null)
                {
                    head = node;
                }
                else
                {
                    current.Next = node;
                }

                current = node;
            }

            public void ListNodes()
            {
                Node tempNode = head;

                while (tempNode != null)
                {
                    Console.WriteLine(tempNode.NodeContent);
                    tempNode = tempNode.Next;
                }
            }

            public Node Retrieve(int position)
            {
                Node tempNode = head;
                Node retNode = null;
                int count = 0;

                while (tempNode != null)
                {
                    if (count == position - 1)
                    {
                        retNode = tempNode;
                        break;
                    }
                    count++;
                    tempNode = tempNode.Next;
                }

                return retNode;
            }

            public bool Delete(int position)
            {
                if (position == 1)
                {
                    head = null;
                    current = null;
                    return true;
                }

                if (position > 1 && position <= size)
                {
                    Node tempNode = head;

                    Node lastNode = null;
                    int count = 0;

                    while (tempNode != null)
                    {
                        if (count == position - 1)
                        {
                            lastNode.Next = tempNode.Next;
                            return true;
                        }
                        count++;

                        lastNode = tempNode;
                        tempNode = tempNode.Next;
                    }
                }
                return false;
            }
        }
    }
}
