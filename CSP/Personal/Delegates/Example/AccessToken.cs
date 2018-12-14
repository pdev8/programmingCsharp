namespace CSP.Personal.Delegates.Example
{
    public static class AccessToken
    {
        public static string GetToken(TokenRequest request)
        {
            var errorMessage = "There was an error retrieving the access token.";

            if (errorMessage.Contains("error"))
            {
                request.OnError?.Invoke("A valid token was not returned from the API.");
            }

            return string.Empty;
        }
    }
}