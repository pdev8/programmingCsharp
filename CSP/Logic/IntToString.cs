using System;

namespace CSP.Logic
{
    public class IntToString
    {
        public static void Run()
        {
            var shipmentId = 123456;

            Console.WriteLine(shipmentId.ToString().Equals("123456", StringComparison.OrdinalIgnoreCase));
        }
    }
}