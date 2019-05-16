using System;

namespace CSP.Mosh.CSharpAdvanced.Delegates
{
    public class FuncDelegate
    {
        public static Func<int, int, string> NamedFuncDelegate { get; set; }

        public static Func<int, int, string> AnonymousFuncDelegate = (digit, digit2) => $"Anonymous said: {digit} + {digit2} = {digit + digit2}";

        public static string NamedMethod(int digit, int digit2) => $"Named said: {digit} + {digit2} = {digit + digit2}";

        public static string GetFuncStringValue(int a, int b)
        {
            return NamedFuncDelegate?.Invoke(a, b);
        }

        public static void Run()
        {
            NamedFuncDelegate = (m, n) => "Go";
            var result = GetFuncStringValue(1, 2);
            Console.WriteLine(result);

            NamedFuncDelegate = NamedMethod;
            var addition = NamedFuncDelegate?.Invoke(5, 9);
            Console.WriteLine(addition);

            Console.WriteLine(AnonymousFuncDelegate?.Invoke(10, 12));
        }
    }
}