namespace RoverControlCenter
{
    class Probe : IDirectable
    {
        public string Alias
        { get; private set; }

        public int YearLaunched
        { get; private set; }

        public int YearLanded
        { get; private set; }

        public Probe(string alias, int yearLaunched)
        {
            Alias = alias;
            YearLaunched = yearLaunched;
            YearLanded = yearLaunched;
        }

        public virtual string GetInfo()
        {
            return $"Alias: {Alias}, YearLaunched: {YearLaunched}";
        }

        public virtual string Explore()
        {
            return "Probe is exploring the surface!";
        }

        public virtual string Collect()
        {
            return "Probe is collecting rocks!";
        }
    }
}

