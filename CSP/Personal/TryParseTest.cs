using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Personal
{
    public class TryParseTest
    {
        public static void Run()
        {
            int.TryParse(null, out var works);
            Console.WriteLine(works);
        }
    }
}
