using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Personal
{
    public class StringToGuid
    {
        public static void Run()
        {
            var license = "";

            var guid = new Guid(license);

            Console.WriteLine(guid);
        }
    }
}
