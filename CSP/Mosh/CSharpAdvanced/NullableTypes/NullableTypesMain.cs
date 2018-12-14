using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.NullableTypes
{
    class NullableTypesMain
    {
        public static void Run()
        {
            // A variable that can have either null or a valid DateTime
            //Nullable<DateTime> date = null;

            // It can also be written this way
            DateTime? date2 = null;

            // If date is null, then the default value will be given
            Console.WriteLine("GetValueOrDefault(): " + date2.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date2.HasValue);
            Console.WriteLine("Value: " + date2.Value);
        }
    }
}
