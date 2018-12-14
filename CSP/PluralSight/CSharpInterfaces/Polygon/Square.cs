using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpInterfaces.Polygon
{
    public class Square : ConcreteRegularPolygon
    {
        public Square(int length) : base(4, length) { }

        public override double GetArea() => SideLength * SideLength;
    }
}
