using System;

namespace CSP.Mosh.CSharpAdvanced.Delegates
{
    public class ActionDelegateExercise
    {
        public static void Run()
        {
            FireAction(CurrencyType.Gold, Console.WriteLine);
        }

        public static void FireAction(CurrencyType currencyType, Action<string> message)
        {
            switch (currencyType)
            {
                case CurrencyType.Bronze:
                    message.Invoke("Bronze was selected");
                    break;
                case CurrencyType.Silver:
                    message.Invoke("Silver was selected");
                    break;
                case CurrencyType.Gold:
                    message.Invoke("Gold was selected");
                    break;
            }
        }

        public enum CurrencyType
        {
            Bronze,
            Silver,
            Gold
        }
    }
}