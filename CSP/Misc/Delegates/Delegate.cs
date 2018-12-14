using System;

namespace CSP.Misc
{
    class Delegate
    {
        delegate void ProcessDelegate(double param1, double param2);

        static void Multiply(double param1, double param2) => Console.WriteLine(param1 * param2);

        static void Divide(double param1, double param2) => Console.WriteLine(param1 / param2);

        public static void Run()
        {
            ProcessDelegate process;
            Console.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(",");

            double param1 = Convert.ToDouble(input.Substring(0, commaPos));
            double param2 = Convert.ToDouble(input.Substring(commaPos + 1).Trim());

            Console.WriteLine("Enter M to multiply or D to divide:");

            input = Console.ReadLine();

            if (input.ToLower() == "m")
                process = Multiply;
            else
                process = Divide;

            process(param1, param2);
        }
    }
}
