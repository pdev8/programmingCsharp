using System;
using System.Collections.Generic;
using System.Linq;

namespace CSP.PluralSight.LearningLINQ.CustomFilterOperator
{
    public static class DeferredExcecutionMain
    {
        public static void Run()
        {
            var movies = new List<Movie>
            {
                new Movie {Title = "Avengers: Infinity War", Rating = 9.0f, Year = 2018},
                new Movie {Title = "Black Panther", Rating = 8.6f, Year = 2018},
                new Movie {Title = "Deadpool 2", Rating = 8.7f, Year = 2018},
                new Movie {Title = "Lion King", Rating = 7.8f, Year = 1996}
            };

            var query = movies.Filter(s => s.Year > 2000);

            using (var enumerator = query.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current?.Title);
                }
            }
        }
    }
}
