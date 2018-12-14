using System;
using System.Collections.Generic;

namespace CSP.PluralSight.CSharpCollections.Dictionaries
{
    class M08P02
    {
        public static void Run()
        {
            // As a List<T>
            //List<PrimeMinister> primeMinisters = new List<PrimeMinister>()
            //{
            //    new PrimeMinister("James Callaghan", 1976),
            //    new PrimeMinister("Margaret Thatcher", 1979),
            //    new PrimeMinister("Tony Blair", 1997)
            //};

            // As a Dictionary<TKey, TValue>
            // Passing String.Comparer into the dictionary constructor can supply different
            // equality comparers fro string
            // StringComparer is provided for us by Microsoft, if this didn't exist we'd have
            // to write our own equality comparer to do case insensitive string comparison
            //Dictionary<string, PrimeMinister> primeMinisters = new Dictionary<string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
            Dictionary<string, PrimeMinister> primeMinisters = new Dictionary<string, PrimeMinister>(new UncasedStringEqualityComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            // Modifying the dictionary
            primeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1976);

            foreach (var pm in primeMinisters.Values)
            {
                // Invokes the ToString() method in PrimeMinister
                Console.WriteLine(pm);
            }

            PrimeMinister primeMin;
            // TryGetValue() returns a boolean
            // The actual value is returned via an out parameter passed into the method
            bool found = primeMinisters.TryGetValue("DC", out primeMin);
            if (found)
                Console.WriteLine("Value is: " + primeMin.ToString() + "\n");
            else
                Console.WriteLine("Value was not in the dictionary");
        }
    }

    class UncasedStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x.ToUpper() == y.ToUpper();
        }

        // When the dictionary calls this method, it'll get exactly the same hash code that
        // it would've gotten if we weren't plugging in the custom comparer. 

        // We have to make sure that the lowercase string and uppercase string both produce the same hash code
        public int GetHashCode(string obj)
        {
            return obj.ToUpper().GetHashCode();
        }
    }
}
