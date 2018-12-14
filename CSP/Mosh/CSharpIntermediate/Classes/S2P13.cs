using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpIntermediate.Classes
{
    class S2P13
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        // Indexer
        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }
    }

    class S2P13Main
    {
        public static void Run()
        {
            var cookie = new S2P13();
            cookie["name"] = "Paul";
            Console.WriteLine(cookie["name"]);
        }
    }
}
