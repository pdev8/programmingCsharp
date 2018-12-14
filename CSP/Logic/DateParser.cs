using System;

namespace CSP.TeknowlogiAPIs
{
    public class DateParser
    {
        public static void Run()
        {
            Console.WriteLine(DateTime.Now.Date.ToString("d"));
            Console.WriteLine(DateTime.Parse($"{DateTime.Now.Date.ToString("MM/dd/yyyy")} 16:00"));
            Console.WriteLine(DateTime.Parse($"{DateTime.Now.Date:d} 16:00"));
        }
    }
}
