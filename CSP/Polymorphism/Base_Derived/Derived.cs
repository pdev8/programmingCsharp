using System;

namespace CSP.Polymorphism
{
    class Derived : Base
    {
        // The overriding method replaces the implementation in the base class
        public override void Call() => Console.WriteLine("Derived");
    }
}