using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    class _10ClassAMain
    {
        // Is there a way to modify ClassA so that you can call the constructor w/
        // parameters, when the Main method is called, w/o creating any other new
        // instances of the ClassA?

        public static void Run()
        {
            _10ClassA refA = new _10ClassA();
        }
    }
}
