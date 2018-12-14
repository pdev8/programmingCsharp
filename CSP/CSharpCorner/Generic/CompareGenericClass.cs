using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.CSharpCorner
{
    class CompareGenericClass<T>
    {
        public bool Compare(T x, T y) => x.Equals(y);
    }
}
