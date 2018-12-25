using System;
using System.Linq;
using System.Text;

namespace CSP.Algorithms
{
    public class ReverseString
    {
        public static void Run()
        {
            Console.WriteLine(Reverse("apple"));
            Console.WriteLine(Reverse("hello"));

            Console.WriteLine(Reverse("Greetings!"));
            Console.WriteLine(Reverse2("Greetings!"));
            Console.WriteLine(Reverse3("Greetings!"));
            Console.WriteLine(Reverse4("Greetings!"));
            Console.WriteLine(Reverse5("Greetings!"));
        }

        public static string Reverse(string str)
        {
            var arr = str.ToCharArray();
            return string.Join("", arr.Reverse());
        }

        public static string Reverse2(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public static string Reverse3(string str)
        {
            var stringBuilder = new StringBuilder();
            for (var i = str.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(str[i]);
            }

            return stringBuilder.ToString();
        }

        public static string Reverse4(string str)
        {
            var reversed = string.Empty;

            foreach (var character in str)
            {
                reversed = character + reversed;
            }

            return reversed;
        }

        public static string Reverse5(string str)
        {
            return new string(str.Select((value, index) => new {value, index}).OrderByDescending(s => s.index).Select(s => s.value).ToArray());
        }
    }
}