namespace CSP.PluralSight.CSharpCollections.Dictionaries
{
    class PrimeMinister
    {
        public string Name { get; private set; }
        public int YearElected { get; private set; }

        public PrimeMinister(string name, int yearElected)
        {
            Name = name;
            YearElected = yearElected;
        }

        public override string ToString()
        {
            return string.Format($"{Name}, elected: {YearElected}");
        }
    }
}
