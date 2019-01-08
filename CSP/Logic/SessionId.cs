using System;
using System.Linq;

namespace CSP.Logic
{
    public class SessionId
    {
        public static void Run()
        {
            Console.WriteLine(GenerateSessionId());
            Console.WriteLine(GenerateSessionId2());
        }

        private static readonly Random Random = new Random();

        private static string GenerateSessionId()
        {
            return new string($"{102387633}{DateTime.Now:ddmmss}{Random.Next(0, 9)}".Take(16).ToArray());
        }

        private static string GenerateSessionId2()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());

            var sessionId = string.Empty;

            for (var i = 0; i < 16; i++)
            {
                sessionId += random.Next(0, 9);
            }

            return sessionId;
        }
    }
}