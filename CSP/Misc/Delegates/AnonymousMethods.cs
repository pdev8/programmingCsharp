using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Delegates
{
    // Declare a delegate
    delegate void Printer(string s);

    class AnonymousMethods
    {
        public static void Run()
        {
            // Instantiate the delegate type using an anonymous method
            Printer p = delegate (string j) { Console.WriteLine(j); };

            // Results from the anonymous delegate call.
            p("The delegate using the anonymous method is called.");

            // The delegate instantiation using a method "DoWork"
            p = new Printer(DoWork);

            // Results from the old style delegate call
            p("The delegate using the name method is called.");
        }

        static void DoWork(string k) => Console.WriteLine(k);
    }
}
