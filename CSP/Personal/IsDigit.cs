using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Personal
{
    public class IsDigit
    {
        public static void Run()
        {
            var postalCode = "92708";

            Console.WriteLine(postalCode.Any(s => !char.IsDigit(s)));
        }
    }
}
