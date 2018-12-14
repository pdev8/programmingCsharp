using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.Ch11Ex01
{
    class MainCopy
    {
        public static void Run()
        {
            Console.WriteLine("Create an Array type collection of Animal obejcts and use it:");
            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Lea");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Noa");

            foreach (Animal myAnimal in animalArray)
            {
                Console.WriteLine($"New {myAnimal.ToString()} object added to Array collection, Name = {myAnimal.Name}");
            }
            Console.WriteLine($"Array collection contains {animalArray.Length} objects.");

            animalArray[0].Feed();
            ((Chicken) animalArray[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Create an ArrayList type collection of Animal objects and use it:");
            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Rual");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Andrea"));

            foreach (Animal myAnimal in animalArrayList)
            {
                Console.WriteLine($"New {myAnimal.ToString()} object added to ArrayList collection, Name = {myAnimal.Name}");
            }
            Console.WriteLine($"ArrayList collection contains {animalArrayList.Count} objects");

            ((Animal) animalArrayList[0]).Feed();
            ((Chicken) animalArrayList[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Additional manipulation of ArrayList:");
            animalArrayList.RemoveAt(0);
            ((Animal) animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken) animalArray[2]).LayEgg();

            Console.WriteLine($"The animal called {myCow1.Name} is at index {animalArrayList.IndexOf(myCow1)}.");
            myCow1.Name = "Mary";
            Console.WriteLine($"The animal is now called {((Animal)animalArrayList[1]).Name}.");
        }
    }
}
