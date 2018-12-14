using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    public class _9TestStatic
    {
        public static int TestValue;

        public _9TestStatic()
        {
            if (TestValue == 0)
                TestValue = 5;
        }

        static _9TestStatic()
        {
            if (TestValue == 0)
                TestValue = 10;
        }

        public void Print()
        {
            if (TestValue == 5)
                TestValue = 6;

            Console.WriteLine("TestValue : " + TestValue);
        }
    }
}
