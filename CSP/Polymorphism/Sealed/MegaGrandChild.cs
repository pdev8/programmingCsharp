using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Polymorphism.Sealed
{
    class MegaGrandChild : GrandGrandChild
    {
        public new void Write() => base.Write();
    }
}
