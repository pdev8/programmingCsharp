using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch11Ex02
{
    class MainCopy
    {
        public static void Run()
        {
            Animals animalCollection = new Animals();
            animalCollection.Add(new Cow("Donna"));
            animalCollection.Add(new Chicken("Keven"));
            foreach (Animal myAnimal in animalCollection)
            {
                myAnimal.Feed();
            }
        }
    }
}
