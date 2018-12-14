using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    class _14KiloToMeters
    {
        public static void Run()
        {
            Console.WriteLine("Enter the distance in kilometers");

            int nDistance = Convert.ToInt32(Console.ReadLine());
            int nResult = nDistance * 1000;

            Console.WriteLine("Distance in meters: " + nResult);
        }
    }
}
