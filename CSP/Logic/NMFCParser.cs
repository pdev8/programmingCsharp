using System;
using System.Linq;

namespace CSP.TeknowlogiAPIs
{
    public class NMFCParser
    {
        public static void Run()
        {
            Console.WriteLine(@"Test 1");
            Console.WriteLine(@"Primary: " + GetNmfcNumber("12345 sub 988").Item1);
            Console.WriteLine(@"Secondary:" + GetNmfcNumber("12345 sub 988").Item2);

            Console.WriteLine(@"Primary: " + GetNmfcNumber("123456 sub 988").Item1);
            Console.WriteLine(@"Secondary:" + GetNmfcNumber("123456 sub 988").Item2);

            Console.WriteLine();

            Console.WriteLine(@"Primary: " + GetNmfcNumber("12345 - 988").Item1);
            Console.WriteLine(@"Secondary:" + GetNmfcNumber("12345 - 988").Item2);

            Console.WriteLine(@"Primary: " + GetNmfcNumber("123456 - 988").Item1);
            Console.WriteLine(@"Secondary:" + GetNmfcNumber("123456 - 988").Item2);

            Console.WriteLine();

            Console.WriteLine(@"Primary: " + GetNmfcNumber("12345 988").Item1);
            Console.WriteLine(@"Secondary:" + GetNmfcNumber("12345 988").Item2);

            Console.WriteLine(@"Primary: " + GetNmfcNumber("123456 988").Item1);
            Console.WriteLine(@"Secondary:" + GetNmfcNumber("123456 988").Item2);
        }

        public static Tuple<string, string> GetNmfcNumber(string nmfcNumber)
        {
            if (nmfcNumber == null)
            {
                nmfcNumber = string.Empty;
            }

            var primaryNmfcNumber = new string(nmfcNumber.TakeWhile(char.IsDigit).Take(6).ToArray());

            var secondaryNmfcNumber = new string(nmfcNumber.Where(char.IsDigit).Skip(primaryNmfcNumber.Length).TakeWhile(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(primaryNmfcNumber) && string.IsNullOrEmpty(secondaryNmfcNumber))
            {
                return new Tuple<string, string>(primaryNmfcNumber, null);
            }

            if (string.IsNullOrEmpty(primaryNmfcNumber) && string.IsNullOrEmpty(secondaryNmfcNumber))
            {
                return default(Tuple<string, string>);
            }

            return new Tuple<string, string>(primaryNmfcNumber, secondaryNmfcNumber);
        }
    }
}