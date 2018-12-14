using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.JustTests
{
    public class BowSpecification
    {
        public int DrawWeight { get; set; }
        public int DrawLength { get; set; }

        public BowSpecification()
        {
            DrawWeight = 60;
            DrawLength = 27;
        }
    }
}
