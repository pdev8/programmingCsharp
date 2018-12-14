using System;
using System.Linq;

namespace CSP.Algorithms
{
    public class ReverseString
    {
        public static void Run()
        {
            Console.WriteLine(Reverse("apple"));
            Console.WriteLine(Reverse("hello"));
            Console.WriteLine(Reverse("Greetings!"));
        }

        public static string Reverse(string str)
        {
            var arr = str.ToCharArray();
            return string.Join("", arr.Reverse());
        }
    }
}