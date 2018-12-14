using System;

namespace CSP.Polymorphism
{
    class Derived2 : Base
    {
        // Hiding the base class method w/ the "new" keyword
        public new void Call() => Console.WriteLine("Derived2");
        // Although the base implementation is hidden, you still have access to it through the base class
    }
}