using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.SOLID
{
    public class DependencyInversion
    {
        public enum Relationship
        {
            Parent,
            Child,
            Sibling
        }

        public class Person
        {
            public string Name { get; set; }
        }

        public interface IRelationshipBrowser
        {
            IEnumerable<Person> FindAllChildrenOf(string name);
        }

        // Instead of depending on a low level module, we depend on an abstraction
        public class Relationships : IRelationshipBrowser
        {
            private List<(Person, Relationship, Person)> relations =
                new List<(Person, Relationship, Person)>();

            public void AddParentAndChild(Person parent, Person child)
            {
                relations.Add((parent, Relationship.Parent, child));
                relations.Add((child, Relationship.Child, parent));
            }

            //public List<(Person, Relationship, Person)> Relations => relations;

            public IEnumerable<Person> FindAllChildrenOf(string name)
            {
                ////foreach (var relation in relations.Where(s => string.Equals(s.Item1.Name, name, StringComparison.OrdinalIgnoreCase) && s.Item2 == Relationship.Parent))
                ////{
                ////    yield return relation.Item3;
                ////}

                return relations.Where(s => string.Equals(s.Item1.Name, name, StringComparison.OrdinalIgnoreCase) && s.Item2 == Relationship.Parent).Select(s => s.Item3);
            }
        }

        public class Research
        {
            ////public Research(Relationships relationships)
            ////{
            ////    var relations = relationships.Relations;
            ////    foreach (var relation in relations.Where(s => string.Equals(s.Item1.Name, "John", StringComparison.OrdinalIgnoreCase) && s.Item2 == Relationship.Parent))
            ////    {
            ////        Console.WriteLine($"John has a child named {relation.Item3.Name}");
            ////    }
            ////}

            public Research(IRelationshipBrowser browser)
            {
                foreach (var p in browser.FindAllChildrenOf("John"))
                {
                    Console.WriteLine($"John has a child named {p.Name}");
                }
            }

            public static void Run()
            {
                var parent = new Person { Name = "John" };
                var child1 = new Person { Name = "Chris" };
                var child2 = new Person { Name = "Mary" };

                var relationships = new Relationships();
                relationships.AddParentAndChild(parent, child1);
                relationships.AddParentAndChild(parent, child2);

                new Research(relationships);
            }
        }
    }
}