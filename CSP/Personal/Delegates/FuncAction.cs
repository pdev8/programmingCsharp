using System;

namespace CSP.Personal.Delegates
{
    public class FuncAction
    {
        // A callback is a function that will be called when a process is done executing
        // a specific task
        public static void Run()
        {
            // To create a callback, a function address needs to be stored in a variable
            WorkCompletedCallBack callBack = TestCallBack;
            DoWork(callBack);

            DoMoreWork(Console.WriteLine);

            // Delegates (see below)
            // ------------------------------------------------------
            Foo fooExample = Bar;
            var time = fooExample(DateTime.UtcNow);
            Console.WriteLine(time);

            // Action delegate (see below)
            // ------------------------------------------------------
            // Named method
            NamedActionDelegate = NamedMethod;
            NamedActionDelegate?.Invoke("Named Action Delegate", 5);

            // Anonymous function
            AnonymousActionDelegate?.Invoke("Anonymous Action Delegate", 106);

            // Func delegate (see below)
            // ------------------------------------------------------
            NamedFuncDelegate = NamedMethod;
            var namedResult = NamedFuncDelegate?.Invoke(100);
            Console.WriteLine(namedResult);
        }

        public delegate void WorkCompletedCallBack(string result);

        public static void DoWork(WorkCompletedCallBack callBack)
        {
            callBack("Hello world!");
        }

        public static void TestCallBack(string result)
        {
            Console.WriteLine(result);
        }

        public static void DoMoreWork(Action<string> callBack)
        {
            callBack("Hello world!");
        }


        // ABOUT DELEGATES
        // ---------------------------
        // In the same fashion that a class is a reference type that holds references to objects,
        // delegates are also reference types, except they hold references to other methods.
        // TLDR; (classes are to objects what delegates are to methods)

        // Types of delegates

        // - The Delegate type (to reference a method to a delegate, the signature of both the delegate
        //   and method must match completely so:
        //   - Return types must be the same
        //   - Input parameters must also be the same (and in matching order)
        // - Example
        //   delegate <return.type> <name> (<type.parameter>);
        //   delegate string Foo(int value);
        public delegate string Foo(DateTime time);

        public static string Bar(DateTime value)
        {
            return value.ToString("t");
        }

        // - The Action delegate (the Action delegate is a delegate which has a return type of void. The
        //   parameters of the action delegate are set using type parameters.
        public static Action<string, int> NamedActionDelegate { get; set; }
        public static Action<string, int> AnonymousActionDelegate = (text, digit) => { Console.WriteLine($"Anonymous said: {text} {digit}"); };

        public static void NamedMethod(string text, int digit)
        {
            Console.WriteLine($"Named said: {text} {digit}");
        }

        // - The Func delegate (the Func delegate is similar to the Action delegate, the difference being that
        //   Func can never return void, it will always require at least one type argument.
        public static Func<int, string> NamedFuncDelegate { get; set; }
        public static Func<int, string> AnonymousFuncDelegate = (digit) => $"Anonymous said: {digit}";

        public static string NamedMethod(int digit) => $"Named said: {digit}";
    }
}