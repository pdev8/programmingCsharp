using System;
using System.Collections.Generic;

namespace CSP.PluralSight.CSharpCollections.Lists.M06P06Test
{
    class M06P06MainCopy
    {
        public static void Run()
        {
            M06P06 lst = new M06P06();
            lst.Add("Item added at index 0");
            lst[0] = "Item changed at index 0";
            lst.Add("Item added at index 1");
            lst.Insert(2, "Item inserted at index 2");

            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
