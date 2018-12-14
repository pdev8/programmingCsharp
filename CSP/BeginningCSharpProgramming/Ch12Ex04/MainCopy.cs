using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch12Ex04
{
    public class MainCopy
    {
        public static void Run()
        {
           Farm<Animal> farm = new Farm<Animal>();
            farm.Animals.Add(new Cow("Rual"));
            farm.Animals.Add(new Chicken("Donna"));
            farm.Animals.Add(new Chicken("Mary"));
            farm.Animals.Add(new SuperCow("Ben"));
            farm.MakeNoises();
            Farm<Cow> dairyFarm = farm.GetCows();
            dairyFarm.FeedTheAnimals();
            foreach (Cow cow in dairyFarm)
            {
                if (cow is SuperCow)
                {
                    //((SuperCow) cow).Fly();
                    (cow as SuperCow).Fly();
                }
            }
        }
    }
}
