using System;

namespace CSP.Personal.Delegates.Example
{
    public class DelegatesEntry
    {
        public static void Run()
        {
            var response = new TokenResponse();

            var accessToken = AccessToken.GetToken(new TokenRequest
            {
                Token = "token",
                OnError = message => { response.ErrorMessage = message; }
            });

            if (!string.IsNullOrEmpty(response.ErrorMessage))
            {
                Console.WriteLine(response.ErrorMessage);
            }
            else
            {
                Console.WriteLine("Something went wrong, this Console.WriteLine should not have been called.");
            }
        }
    }
}