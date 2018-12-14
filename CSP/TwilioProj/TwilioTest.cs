using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace CSP.TwilioProj
{
    public class TwilioTest
    {
        public static void Run()
        {
            // Your Account SID from twilio.com/console
            var accountSid = "AC41bb755533c36a79ea1bd6e8193cd1ce";
            // Your Auth Token from twilio.com/console
            var authToken = "4643c885d824efaba2b6efd906943cd9";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber("+19498728227"),
                from: new PhoneNumber("+16572438100"),
                body: "Let's eat some cheese and crackers + prosciutto :')");

            Console.WriteLine(message.Sid);
            Console.Write("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
