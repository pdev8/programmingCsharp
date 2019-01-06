using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.SOLID.Exercises
{
    public class LiskovSubstitutionMixingClasses
    {
        public static void Run()
        {
            BaseClass test = new BaseClass();
            test.PrintStatement();

            BaseClass test2 = new SubClass();
            test2.PrintStatement();

            BaseClass test3 = new BaseClass();
            ////((SubClass)test3).PrintStatement(); // Cannot cast to SubClass

            BaseClass test4 = new BaseClass();
            (test3 as SubClass)?.PrintStatement();

            BaseClass test5 = new SubClass();
            ((BaseClass)test5).PrintStatement();

            SubClass test6 = new SubClass();
            ((BaseClass)test6).PrintStatement();
        }
    }

    public class BaseClass
    {
        public virtual void PrintStatement()
        {
            Console.WriteLine($"Print from base class.");
        }
    }

    public class SubClass : BaseClass
    {
        public override void PrintStatement()
        {
            Console.WriteLine($"Print from subclass.");
        }
    }
}