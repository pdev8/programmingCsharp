using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSP.PluralSight.RegularExpressions
{
    public class RegexMatch
    {
        private const string MatchSuccess = "{0} @{1}:{2}";
        public static void Run(string[] args)
        {
            var pattern = args[0];
            var subject = args[1];

            var regex = new Regex(pattern);

            var match = regex.Match(subject);

            if (match.Success)
            {
                Console.WriteLine(MatchSuccess, match.Success, match.Index, match.Length);
            }
            else
            {
                Console.WriteLine(match.Success);
            }
        }
    }
}
