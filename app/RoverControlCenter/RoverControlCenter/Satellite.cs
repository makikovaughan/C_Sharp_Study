namespace RoverControlCenter
{
    class Satellite : Probe
    {
        public Satellite(string alias, int yearLaunched) : base(alias, yearLaunched)
        {
        }

        public override string Explore()
        {
            return "Satellite is exploring the far reaches of space!";
        }

        public override string Collect()
        {
            return "Satellite is collecting photographic evidence!";
        }
    }
}
