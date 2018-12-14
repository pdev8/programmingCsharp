using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP
{
    class ClassA
    {
        private int state = -1;

        public int State => state;

        public class ClassB
        {
            public void SetPrivateState(ClassA target, int newState)
            {
                target.state = newState;
            }
        }
    }
}
