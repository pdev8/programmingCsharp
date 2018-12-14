using System;

namespace CSP.Personal.Delegates.SelfTest
{
    public class TokenRequestResponse
    {
        public string ApiKey { get; set; }

        public Action<string> OnError { get; set; }
    }
}