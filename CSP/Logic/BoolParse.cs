using System;

namespace CSP.TeknowlogiAPIs
{
    public class BoolParse
    {
        public static void Run()
        {
            bool.TryParse("True" ?? "false", out var test);
            string testMode = "N";
            if (test)
            {
                testMode = "Y";
            }

            Console.WriteLine($"When 'testMode' is true: {testMode}");

            bool.TryParse("False" ?? "false", out var test2);
            string testMode2 = "N";
            if (test2)
            {
                testMode2 = "Y";
            }

            Console.WriteLine($"When 'testMode' is true: {testMode2}");

            bool.TryParse(null, out var test3);
            string testMode3 = "N";
            if (test3)
            {
                testMode3 = "Y";
            }

            Console.WriteLine($"When 'testMode' is true: {testMode3}");
        }
    }
}