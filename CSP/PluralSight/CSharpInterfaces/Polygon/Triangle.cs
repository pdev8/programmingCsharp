using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpInterfaces.Polygon
{
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) : base(3, length) { }

        public override double GetArea() => SideLength * SideLength * Math.Sqrt(3) / 4;
    }
}
