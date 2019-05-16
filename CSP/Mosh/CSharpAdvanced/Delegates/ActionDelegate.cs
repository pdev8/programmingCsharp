using System;

namespace CSP.Mosh.CSharpAdvanced.Delegates
{
    public class ActionDelegate
    {
        public static Action<string, int> NamedActionDelegate { get; set; }

        public static Action<string, int> AnonymousActionDelegate = (text, digit) => Console.WriteLine($"Anonymous said: {text} {digit}");

        public static void NamedMethod(string text, int digit)
        {
            Console.WriteLine($"Named said: {text} {digit}");
        }

        public static void Run()
        {
            NamedActionDelegate = NamedMethod;
            NamedActionDelegate?.Invoke("Hi", 5);

            AnonymousActionDelegate?.Invoke("Hi", 5);
        }
    }
}