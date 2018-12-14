using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpInterfaces.Polygon
{
    public class Octagon : Object, IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        #region Constructor
        public Octagon(int length)
        {
            NumberOfSides = 8;
            SideLength = length;
        }
        #endregion

        public double GetPerimeter() => NumberOfSides * SideLength;

        public double GetArea() => Math.Pow(SideLength, 2) * (2 + 2 * Math.Sqrt(2));
    }
}
