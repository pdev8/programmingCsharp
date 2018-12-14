using System;

namespace CSP.Personal.Delegates.Example
{
    public class TokenRequest
    {
        public string Token { get; set; }

        public Action<string> OnError { get; set; }
    }
}