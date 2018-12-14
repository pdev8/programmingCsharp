using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.CSharpCorner.Generic
{
    class CompareGenericClassMainCopy
    {
        public static void Run()
        {
            CompareGenericClass<int> test = new CompareGenericClass<int>();
            Console.WriteLine(test.Compare(4, 4));
        }
    }
}
