using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.TeknowlogiAPIs
{
    public class EDIExpress
    {
        public static void Run()
        {
            var response = new Dictionary<string, string[]>();
            response.Add("PhoneErrors", new[]
            {
                "There is a phone error.",
                "There is a phone error."
            });

            response.Add("ContactErrors", new[]
            {
                "There is a contact error.",
                "There is a contact error."
            });

            var errors = response.Values.SelectMany(s => s).Distinct();
            //var allErrors = errors.SelectMany(s => s);
        }

        public class Response
        {
            public string[] PhoneErrors { get; set; }

            public string[] ContactErrors { get; set; }

            public string[] AddressErrors { get; set; }
        }
    }
}
