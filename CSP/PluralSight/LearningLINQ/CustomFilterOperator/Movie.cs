using System;

namespace CSP.PluralSight.LearningLINQ.CustomFilterOperator
{
    public class Movie
    {
        public string Title { get; set; }
        public float Rating { get; set; }

        private int _year;

        public int Year
        {
            get
            {
                Console.WriteLine($"Returning {_year} for {Title}");
                return _year;
            }
            set => _year = value;
        }
    }
}
