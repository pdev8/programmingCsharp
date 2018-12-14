using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.GitHub.DependencyInjection
{
    class SamuraiMain
    {
        public static void Run()
        {
            var warrior1 = new Samurai(new Sword());
            warrior1.Attack("the evildoers");
        }
    }
}
