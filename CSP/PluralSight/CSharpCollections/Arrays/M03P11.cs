using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpCollections.Arrays
{
    class M03P11
    {
        public static void Run()
        {
            Person[] people = new Person[]
            {
                new Person {Name = "Bill", Age = 7},
                new Person {Name = "Ben", Age = 8}
            };

            foreach (Person person in people)
            {
                // The people array contains two reference, and after executing the foreach
                // loop those reference still point to the same objects. It's the values of
                // those objects that's changed.
                person.Age = 20;
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => String.Format($"Name = {Name}, age = {Age}");
    }
}
