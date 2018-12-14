using System;

namespace CSP.Personal.Delegates.SelfTest
{
    public class DelegatesEntryTest
    {
        public static void Run()
        {
            var tokenResponse = new TokenResponse();

            var accessToken = AccessToken.GetToken(new TokenRequestResponse
            {
                ApiKey = "ABC123!@#",
                OnError = message => { tokenResponse.ErrorMessage = message; }
            });

            Console.WriteLine(!string.IsNullOrEmpty(tokenResponse.ErrorMessage) ? $"Success: {tokenResponse.ErrorMessage}" : "Failed.");
        }
    }
}