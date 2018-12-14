using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Mosh.CSharpAdvanced.Delegates
{
    class Photo
    {
        public static Photo Load(string path) => new Photo();

        public void Save() { }
    }
}
