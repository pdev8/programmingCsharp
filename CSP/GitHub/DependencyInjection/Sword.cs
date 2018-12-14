using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.GitHub.DependencyInjection
{
    class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"Chopped {target} in half.");
        }
    }
}
