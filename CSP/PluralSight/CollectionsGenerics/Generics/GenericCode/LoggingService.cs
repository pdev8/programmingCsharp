using System;

namespace CSP.PluralSight.CollectionsGenerics.Generics.GenericCode
{
    public class LoggingService
    {
        public static string LogAction(string action)
        {
            var logText = "Action: " + action;
            Console.WriteLine(logText);

            return logText;
        }
    }
}
