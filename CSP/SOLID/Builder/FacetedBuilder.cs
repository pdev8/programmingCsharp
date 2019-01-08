using System;

namespace CSP.SOLID.Builder
{
    public class FacetedBuilder
    {
        public static void Run()
        {
            var pb = new PersonBuilder();
            Person person = pb
                .Works.At("Teknowlogi")
                .AsA("Developer")
                .Earning(100000);

            Console.WriteLine(person);
        }
    }

    public class Person
    {
        public string StreetAddress, Postcode, City;

        public string CompanyName, Position;
        public int AnnualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }

    public class PersonBuilder // facade for other builders - doesn't build the whole person object
    {
        // reference type!
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);

        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.person;
        }
    }

    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int amount)
        {
            person.AnnualIncome = amount;
            return this;
        }
    }
}