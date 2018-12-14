using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.DotNetPerls.Generic
{
    class MainCopy
    {
        public static void Run()
        {
            Test<int> test1 = new Test<int>(5);
            test1.Write();

            Test<string> test2 = new Test<string>("cat");
            test2.Write();
        }
    }
}
