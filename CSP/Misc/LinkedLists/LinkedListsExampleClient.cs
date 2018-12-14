using System;
using CSP.Misc.LinkedLists;

namespace CSP.Misc.LinkedLists
{
    class LinkedListExampleClient
    {
        public static void Run()
        {
            LinkedListExample.List list = new LinkedListExample.List();

            list.Add("A");
            list.Add("B");
            list.Add("C");
            list.Add("D");
            list.Add("E");
            list.Add("F");
            list.Add("G");
            list.Add("H");

            list.ListNodes();
            Console.WriteLine();

            Console.WriteLine("Deleting node 8");
            list.Delete(8);
            list.ListNodes();

            Console.WriteLine();
            Console.WriteLine($"Position 5: {list.Retrieve(5).NodeContent}");

            Console.WriteLine();
            Console.WriteLine("Deleting node 5");
            list.Delete(5);

            Console.WriteLine();
            Console.WriteLine($"Position 5: {list.Retrieve(5).NodeContent}");

            Console.WriteLine();
            list.ListNodes();
        }
    }
}
