using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.ExtensionMethods
{
    class ExtensionMethodsMain
    {
        public static void Run()
        {
            string post = "This is supposed to be a very long blog post blah blah blah...";

            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }
}
