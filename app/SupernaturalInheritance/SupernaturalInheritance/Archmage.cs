// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {

        //Constructor
        public Archmage(string title) : base(title) { }

        public Archmage(string title, string origin) : base(title, origin) { }

        //Method
        public override Storm CastRainStorm()
        {
            return new Storm(Origin, true, Title);
        }

        public Storm CastLightningStorm()
        {
            return new Storm(Origin, true, Title);
        }

    }
}

