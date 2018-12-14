using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.Collections
{
    class M05P07
    {
        public static void Run()
        {
            ICollection<string> collection = DoW.DaysOfWeek;
            Console.WriteLine($"Count = {collection.Count}");
        }
    }
}
