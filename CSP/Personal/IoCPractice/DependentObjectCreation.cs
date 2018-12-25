using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Personal.IoCPractice
{
    /// <summary>
    /// Follows work from: http://www.tutorialsteacher.com/ioc/inversion-of-control
    ///
    /// class A calls b.SomeMethod() to complete its task1. Class A cannot complete its
    /// task w/o class B and so it can be said that "Class A is dependent on class B" or
    /// "Class B is a dependency of class A"
    /// 
    /// </summary>
    public class DependentObjectCreation
    {
        public class A
        {
            B b;

            public A()
            {
                // b = new B(); Does not follow IoC
                b = Factory.GetObjectOfB(); // Class A uses Factory class to get an object of class B
                                            // Thus, we have inverted the dependent object creation
                                            // from class A to Factory. The class A no longer creates
                                            // an object of class B instead it use Factory class to get
                                            // get the object of class B
            }

            public void Task1()
            {
                // do something here...
                b.SomeMethod();
                // do something here...
            }
        }

        public class B
        {
            public void SomeMethod()
            {
                // doing something...
            }
        }

        public class Factory
        {
            public static B GetObjectOfB()
            {
                return new B();
            }
        }
    }
}
