using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch12Ex04
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name) { }

        public void Milk() => Console.WriteLine($"{name} has been milked.");

        public override void MakeANoise() => Console.WriteLine($"{name} says 'moo!'");
    }
}
