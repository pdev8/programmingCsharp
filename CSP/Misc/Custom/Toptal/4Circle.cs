using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Misc.Custom.Toptal
{
    public sealed class _4Circle
    {
        private double _radius;

        public double Calculate(Func<double, double> op) => op(_radius);

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }
    }
}
