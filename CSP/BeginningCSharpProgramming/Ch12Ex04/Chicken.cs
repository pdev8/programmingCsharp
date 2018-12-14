using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch12Ex04
{
    public class Chicken : Animal
    {
        public Chicken(string name) : base(name) { }

        public void LayEgg() => Console.WriteLine($"{name} has laid an egg.");

        public override void MakeANoise() => Console.WriteLine($"{name} says 'cluck!';");
    }
}
