using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSP.Udemy
{
    public class RegexTest
    {
        public static void Run()
        {
            string trueEmail = "<ppauleee@gmail.com>";
            string falseEmail = "mhlee3721@gmail.com";

            string pattern = @"(?<=<).*?(?=>)";
            string ePattern = @"[a-zA-Z]";

            var found = Regex.Match(trueEmail, pattern);
            var notFound = Regex.Match(falseEmail, pattern);

            var numberMatches = Regex.Match(falseEmail, @"[0-9]");

            Console.Write("PrintEachLine: ");
            PrintEachLine();

            Console.Write("Print phone numbers: ");
            PrintPhoneNumber();

            Console.Write("Print date, fruit and quantity: ");
            PrintFruitInfo();

            Console.WriteLine($"Email: {(found.Success ? found.Value : "Couldn't find the email.")}");
            Console.WriteLine($"Email: {(notFound.Success ? notFound.Value : "Couldn't find the email.")}");
            Console.WriteLine($"Michelle's email: {Regex.Match(falseEmail, @"[0-9]")}");
            Console.WriteLine($"Trying to print the word trying: {Regex.Match(@"Trying to pring the word trying", @"^\w+")}");

            Console.WriteLine($"{Regex.Match(trueEmail, ePattern).Value}");

            Console.WriteLine($"Thank Goodness It's Friday!: {Regex.Match(@"Thank\nGoodness\nIt's\Friday!", @"(?m)^\w")}");

            Regex myRegex = new Regex("[^a-z]", RegexOptions.IgnoreCase);
            string s = myRegex.Replace(trueEmail, string.Empty);
            Console.WriteLine(s);
        }

        public static void PrintEachLine()
        {
            string paragraph = "Thank\nGoodness\nIt's\nFriday!";

            var matches = Regex.Matches(paragraph, @"(?m)^\w");

            foreach (Match match in matches)
            {
                Console.Write(match.Value);
            }

            Console.WriteLine();
        }

        public static void PrintPhoneNumber()
        {
            var phoneNumber = @"+92 (123) 455-6000";

            //var pattern = @"(?mx)^(\+\d{1,2}\ )?
            //                \(?\d{3}\)?
            //                \ \d{3}-\d{4}";

            //var regex = new Regex(pattern);

            var regex = new Regex(@"(?mx)^(?:\+\d{1,2}\ )?
                                    \(?\d{3}\)?
                                    [\ \.-]
                                    \d{3}
                                    [\ \.-]
                                    \d{4}");

            var match = regex.Match(phoneNumber).Value;

            Console.WriteLine(match);
        }

        public static void PrintFruitInfo()
        {
            var csvFruitData = new List<string>
            {
                "4/5/2015 13:34,Apples,73",
                "4/5/2015 3:41,Cherries,85",
                "4/6/2015 12:46,Pears,14",
                "4/8/2015 8:59,Oranges,52",
                "4/10/2015 2:07,Apples,152",
                "4/10/2015 18:10,Bananas,23",
                "4/10/2015 2:40,Strawberries,98"
            };

            var csvFruitDataValid = new List<Match>();

            //var regex = new Regex(@"(?mx)^(\d{1,2}\/\d{1,2}\/\d{4}\ 
            //                        \d{1,2}\:\d{1,2})
            //                        \,([A-Za-z]*)
            //                        \,(\d{1,4})");

            var regex = new Regex(@"[^,\n]+");

            csvFruitDataValid.AddRange(csvFruitData.Select(s => regex.Match(s)));
        }
    }
}
