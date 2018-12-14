using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.Algorithms
{
    public class DogBread
    {
        private class Dog
        {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public int sortOrder { get; set; }

            public void print()
            {
                Console.WriteLine("Dog - " + this.id);
                Console.WriteLine("Name - " + this.name);
                Console.WriteLine("--------------------");
            }
        }


        /*
         * Complete the functions below.
         */
        ///<summary>Print ONLY the dog names</summary>
        static void printDogNames()
        {
            dogs.ForEach(s => s.print());
            dogs.Select(s => new {dogName = $"Dog's first name: {s.name}", dogAge = s.age}).ToList().ForEach(s => Console.WriteLine(s.dogName));
        }
        ///<summary>Print all dogs order by their sortOrder property</summary>
        static void printDogsInOrder()
        {
            dogs.OrderBy(s => s.sortOrder).ThenBy(s => s.name).ToList().ForEach(s => s.print());
        }
        ///<summary>Print all dogs that have an age > 3 (sorted by sortOrder descending)</summary>
        static void printDogsOverAge3()
        {
            dogs.Where(s => s.age > 3).OrderByDescending(s => s.sortOrder).ToList().ForEach(s => s.print());
        }


        private static List<Dog> dogs;

        public static void Run()
        {

            dogs = new List<Dog>()
            {
                new Dog() {id = 1, name = "Fido", age = 10, sortOrder = 2},
                new Dog() {id = 2, name = "Spot", age = 1, sortOrder = 0},
                new Dog() {id = 3, name = "Sam", age = 4, sortOrder = 0},
                new Dog() {id = 4, name = "Jim", age = 12, sortOrder = 5},
                new Dog() {id = 5, name = "Spotty", age = 2, sortOrder = 4},
                new Dog() {id = 6, name = "Alfred", age = 4, sortOrder = 1}
            };

            printDogNames();
            ////Console.WriteLine();
            ////printDogsInOrder();
            ////Console.WriteLine();
            ////printDogsOverAge3();
        }
    }
}