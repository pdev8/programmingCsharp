using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.Collections
{
    class M05P08
    {
        public static void Run()
        {
            // Expliciit interface implementation - lets you convert the array to the interface
            ICollection<string> collection = DoW.DaysOfWeek;

            // Can replace elements of an array by casting the collection to a string
            (collection as string[])[5] = "SlaveDay";

            // Another way to write
            ((string[]) collection)[4] = "CakeDay";

            if (!collection.IsReadOnly)
                collection.Add("SlaveDay");
            else
                Console.WriteLine("Collection is read only");

            foreach (string day in collection)
            {
                Console.WriteLine(day);
            }
        }
    }
}
