using System;
using System.Collections.Generic;

namespace CSP.PluralSight.CSharpCollections.LinkedLists
{
    class M07P03
    {
        public static void Run()
        {
            LinkedList<string> foods = new LinkedList<string>();
            foods.AddLast("Cheeseburger");
            foods.AddLast("Pizza");
            foods.AddLast("Steak");
            foods.AddLast("Pancake");

            foods.RemoveFirst();
            LinkedListNode<string> hamburger = foods.AddFirst("Hamburger"); // Add method creates/returns the LinkedListNode<T>

            LinkedListNode<string> steak = foods.Find("Steak"); // Searches through the list and returns a LinkedListNode
            foods.AddAfter(steak, "Cake");

            foreach (string food in foods)
            {
                Console.WriteLine(food);
            }
        }
    }
}
