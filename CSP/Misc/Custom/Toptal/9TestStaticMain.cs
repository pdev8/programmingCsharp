using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    class _9TestStaticMain
    {
        // What is the output of the program?
        public static void Run()
        {
            _9TestStatic t = new _9TestStatic();
            t.Print();
        }

        // Paul's Answer
        // 6

        // Toptal's Answer
        // 10
        // Toptal's Explanation
        // The static constructor of a class is called before any instance of the
        // class is created. The static constructor called here initializes the
        // TestValue variable first
    }
}
