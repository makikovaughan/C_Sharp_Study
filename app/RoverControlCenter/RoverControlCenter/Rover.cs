namespace RoverControlCenter
{
    class Rover : Probe
    {

        public Rover(string alias, int yearLanded) : base(alias, yearLanded)
        {
        }

        public override string GetInfo()
        {
            return $"Alias: {Alias}, YearLanded: {YearLanded}";
        }

        public override string Explore()
        {
            return "Rover is exploring the surface!";
        }

        public override string Collect()
        {
            return "Rover is collecting rocks!";
        }
    }
}