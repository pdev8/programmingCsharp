using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.DotNetPerls.Generic
{
    class Test<T>
    {
        T _value;

        public Test(T t)
        {
            this._value = t;
        }

        public void Write()
        {
            Console.WriteLine(this._value);
        }
    }
}
