using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch12Ex03
{
    public static class VectorDelegates
    {
        public static int Compare(Vector x, Vector y)
        {
            if (x.R > y.R)
                return 1;
            else if (x.R < y.R)
                return -1;
            return 0;
        }

        public static bool TopRightQuadrant(Vector target) => target.Theta >= 0.0 && target.Theta <= 90.0;
    }
}