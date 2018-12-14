using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.SEW
{
    class Challenge
    {
        public static void Run()
        {
            List<string> list = new List<string>();
            using (StreamReader reader =
                new StreamReader(@"C:\Users\ppauleee\Documents\Personal\BegVCSharp\Chapter13\CSP\CSP\SEW\wordlist.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            

        }
    }
}
