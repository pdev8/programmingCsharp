using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes
{
    class S2P12
    {
        public S2P12(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // This auto-implemented property has a private field provided by the compiler
        // The private set accessor is a read-only
        public DateTime Birthdate { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }

    internal class S2P12Main
    {
        public static void Run()
        {
            S2P12 person = new S2P12(new DateTime(1990, 4, 7));
            // This cannot be done because we have a private set
            //person.Birthdate = new DateTime(1990, 4, 7);
            Console.WriteLine(person.Age);
        }
    }
}
