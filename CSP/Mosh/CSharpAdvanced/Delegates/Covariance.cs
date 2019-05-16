using System;
using CSP.Mosh.CSharpAdvanced.Delegates;

public delegate Small covarDel(Big mc);

namespace CSP.Mosh.CSharpAdvanced.Delegates
{
    public class Covariance
    {
        public static void Run()
        {
            covarDel del = Method1;

            Small sm1 = del(new Big());

            del = Method2;

            Small sm2 = del(new Big());
        }

        public static Big Method1(Big big)
        {
            Console.WriteLine("Method 1");

            return new Big();
        }

        public static Small Method2(Big big)
        {
            Console.WriteLine("Method 2");

            return new Small();
        }
    }

    public class Small
    {
    }

    public class Big : Small
    {
    }

    public class Bigger : Big
    {
    }
}