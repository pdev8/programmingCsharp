using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.Utilities;

namespace CSP.Algorithms
{
    /// <summary>
    ///
    /// --- Directions
    /// Write a function that accepts a string. The function should capitalize
    /// the first letter of each word in the string then return the capitalized
    /// string.
    /// --- Examples
    ///     capitalize('a short sentence') --> 'A Short Sentence'
    ///     capitalize('a lazy fox') --> 'A Lazy Fox'
    ///     capitalize('look, it is working!') --> 'Look, It Is Working!'
    /// 
    /// </summary>
    public class Capitalization
    {
        public static void Run()
        {
            Console.WriteLine(Capitalize2("a short sentence"));
            Console.WriteLine(Capitalize2("a lazy fox"));
            Console.WriteLine(Capitalize2("look, it is working!"));
        }

        private static string Capitalize(string str)
        {
            return string.Join(" ", str.Split().Select(s => string.Format($"{char.ToUpper(s[0])}{s.Substring(1)}")));
        }

        private static string Capitalize2(string str)
        {
            str = str.Trim();

            var newStr = new StringBuilder();
            for (var i = 0; i < str.Length; i++) 
            {
                if (i == 0 || str[i - 1] == ' ')
                {
                    newStr.Append(char.ToUpper(str[i]));
                }
                else
                {
                    newStr.Append(str[i]);
                }
            }

            return newStr.ToString();
        }
    }
}