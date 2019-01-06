namespace CSP.Polymorphism.Base_Derived
{
    class MainCopy
    {
        public static void Run()
        {
            Base test = new Base();
            test.Call();

            Base test2 = new Derived();
            test2.Call();

            Derived test3 = new Derived();
            test3.Call();
            
            Base test4 = new Derived2();
            test4.Call();

            Base test5 = new Derived2();
            ((Derived2) test5).Call();

            Derived2 test6 = new Derived2();
            test6.Call();

            Derived2 test7 = new Derived2();
            ((Base) test7).Call();

            Derived test8 = new Derived();
            ((Base)test8).Call();
        }
    }
}