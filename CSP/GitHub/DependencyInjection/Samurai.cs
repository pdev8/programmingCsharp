using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.GitHub.DependencyInjection
{
    class Samurai
    {
        private readonly IWeapon _weapon;

        public Samurai(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack(string target)
        {
            _weapon.Hit(target);
        }
    }
}
