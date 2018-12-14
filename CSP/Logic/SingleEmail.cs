using System;
using System.Linq;

namespace CSP.TeknowlogiAPIs
{
    public static class SingleEmail
    {
        public static void Run()
        {
            Console.WriteLine(SetRequestorEmail("fjdsoiafjds@jfsoijfiod.com,paul.lee@teknowlogi.com,lee.paul@teknowlogi.com,p.l@teknowlogi.com"));
            Console.WriteLine(SetRequestorEmail("ppauleee@gmail.com"));
            Console.WriteLine(SetRequestorEmail(null));
        }

        private static string SetRequestorEmail(string email)
        {
            if (!string.IsNullOrEmpty(email))
            {
                if (email.ToLower().Contains(","))
                {
                    return email.Split(',').First().Truncate(60);
                }

                return email.Truncate(60);
            }

            return "billTo@billTo.com";
        }

        public static string Truncate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return str.Length > maxLength ? str.Substring(0, maxLength) : str;
        }
    }
}