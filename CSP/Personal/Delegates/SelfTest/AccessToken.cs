using System;

namespace CSP.Personal.Delegates.SelfTest
{
    public class AccessToken
    {
        public static string GetToken(TokenRequestResponse response)
        {
            // Do work to get access token
            var errorMessage = "An error occurred while generating a token.";

            if (errorMessage.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                response.OnError?.Invoke("An access token failed to generate.");
            }

            return string.Empty;
        }
    }
}