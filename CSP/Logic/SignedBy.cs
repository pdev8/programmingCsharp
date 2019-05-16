using System;

namespace CSP.Logic
{
    public static class SignedBy
    {
        public static void Run()
        {
            var signedBy = "Not Available";
            var signedBy2 = string.Empty;
            var signedBy3 = (string)null;
            var signedBy4 = "Rob";

            CheckSignedBy(signedBy);
            CheckSignedBy(signedBy2);
            CheckSignedBy(signedBy3);
            CheckSignedBy(signedBy4);
        }

        private static void CheckSignedBy(string signedBy)
        {
            if (!string.IsNullOrWhiteSpace(signedBy) && !signedBy.Contains("Not Available", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Is working for: {signedBy}");
            }
            else
            {
                Console.WriteLine($"Is not working for: {signedBy}");
            }
        }

        private static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}