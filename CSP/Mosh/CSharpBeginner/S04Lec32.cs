using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpBeginner
{
    public static class S04Lec32
    {
        public static void Run()
        {
            string firstName = "Paul";
            string lastName = "Lee";

            string fullName = String.Format("My name is {0} {1}", firstName, lastName);

            string[] names = { "John", "Jack", "Jill" };
            string formattedName = String.Join(", ", names);

            // String verbatim
            string text = @"Hi John,
Look into the following paths:
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text);
        }
    }
}
