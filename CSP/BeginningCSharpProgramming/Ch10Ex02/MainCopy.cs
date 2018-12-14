using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch10Ex02
{
    class MainCopy
    {
        public static void Run()
        {
            ClassA myObject = new ClassA();
            Console.WriteLine($"myObject.State = {myObject.State}");
            ClassA.ClassB myOtherObject = new ClassA.ClassB();
            myOtherObject.SetPrivateState(myObject, 999);
            Console.WriteLine($"myObject.State = {myObject.State}");
        }
    }
}
