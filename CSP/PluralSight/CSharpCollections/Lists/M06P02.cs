using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSP.PluralSight.CSharpCollections.Lists
{
    class M06P02
    {
        public static void Run()
        {
            List<string> menu = new List<string>
            {
                "Hamburger",
                "Pizza",
                "Hot Dog",
                "Burrito",
                "Sandwich"
            };

            Console.WriteLine("Before:");
            Console.WriteLine($"Count = {menu.Count}");
            Console.WriteLine($"Capacity = {menu.Capacity} \r\n");
            menu.Add("Spaghetti");
            Console.WriteLine("After:");
            Console.WriteLine($"Count = {menu.Count}");
            Console.WriteLine($"Capacity = {menu.Capacity} \r\n");

            IList copy = new ReadOnlyCollection<string>(menu);

            foreach (string food in menu)
            {
                Console.WriteLine(food);
            }
        }
    }
}
