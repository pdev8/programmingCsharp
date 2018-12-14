using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.CSharpInterfaces.FutureProofing.PersonLibrary
{
    public class PeopleRepository
    {
        public Person[] GetPeople()
        {
            Person[] people = new Person[]
            {
                new Person()
                {
                    FirstName = "Michelle",
                    LastName = "Lee",
                    StartDate = DateTime.Parse("1/1/2018"),
                    Rating = 10
                },
                new Person()
                {
                    FirstName = "Paul",
                    LastName = "Lee",
                    StartDate = DateTime.Parse("1/1/2018"),
                    Rating = 10
                }
            };

            return people;
        }
    }
}
