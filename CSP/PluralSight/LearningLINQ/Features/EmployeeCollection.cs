using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.PluralSight.LearningLINQ.Features
{
    public class EmployeeCollection
    {
        public static void Run()
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee() {Id = 1, Name = "Paul"},
                new Employee() {Id = 2, Name = "Michelle"},
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee() {Id = 3, Name = "April"}
            };

            Console.WriteLine(developers.Count());
        }
    }

    public static class MyLinq
    {
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            int count = 0;

            foreach (var item in sequence)
            {
                count++;
            }

            return count;
        }
    }
}
