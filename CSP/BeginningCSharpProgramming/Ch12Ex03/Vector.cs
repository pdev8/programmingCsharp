using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch12Ex03
{
    public class Vector
    {
        public double? R = null;
        public double? Theta = null;

        public double? ThetaRadians
        {
            get => Theta * Math.PI / 180.0;
        }

        public Vector(double? r, double? theta)
        {
            if (r < 0)
            {
                r = -r;
                theta += 180;
            }
            theta = theta % 360;

            R = r;
            Theta = theta;
        }

        public static Vector operator +(Vector op1, Vector op2)
        {
            try
            {
                // Get (x, y) coordinates for new vector
                double newX = op1.R.Value * Math.Sin(op1.ThetaRadians.Value) +
                              op2.R.Value * Math.Sin(op2.ThetaRadians.Value);
                double newY = op1.R.Value * Math.Cos(op1.ThetaRadians.Value) +
                              op2.R.Value * Math.Cos(op2.ThetaRadians.Value);
                double newR = Math.Sqrt(newX * newX + newY * newY);
                double newTheta = Math.Atan2(newX, newY) * 180.0 / Math.PI;

                return new Vector(newR, newTheta);
            }
            catch
            {
                return new Vector(null, null);
            }
        }

        public static Vector operator -(Vector op1) => new Vector(-op1.ThetaRadians, op1.Theta);
        public static Vector operator -(Vector op1, Vector op2) => op1 + (-op2);

        public override string ToString()
        {
            string rString = R.HasValue ? R.ToString() : "null";
            string thetaString = Theta.HasValue ? Theta.ToString() : "null";

            return string.Format($"({rString}, {thetaString})");
        }
    }
}
