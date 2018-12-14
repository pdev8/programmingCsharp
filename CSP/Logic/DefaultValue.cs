using System;

namespace CSP.TeknowlogiAPIs
{
    public class DefaultValue
    {
        public static void Run()
        {
            var name = string.Empty;
            string name2 = null;

            Console.WriteLine(!string.IsNullOrEmpty(name) ? name : !string.IsNullOrEmpty(name2) ? name2 : "Default Value");
        }
    }
}
