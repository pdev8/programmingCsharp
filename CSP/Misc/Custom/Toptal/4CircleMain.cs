using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    class _4CircleMain
    {
        public static void Run()
        {
            _4Circle circle = new _4Circle();
            double radius = 6;
            Console.WriteLine(circle.Calculate(r => 2 * Math.PI * radius));
        }
    }
}
