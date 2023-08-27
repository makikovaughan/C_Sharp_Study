// Storm.cs
using System;

namespace MagicalInheritance
{
    class Storm : Spell
    {

        //Automatic properties
        /* 
        We created Spell, so we do not need this anymore.
        public string Essence
        {get; private set;}

        public bool IsStrong
        {get; private set;}

        public string Caster
        {get; private set;} */

        //Constructor
        public Storm(string essence, bool isStrong, string caster)
        {
            Essence = essence;
            IsStrong = isStrong;
            Caster = caster;
        }

        //Method
        public override string Announce()
        {
            if (IsStrong)
            {
                return $"{Caster} cast a strong {Essence}!";
            }
            else
            {
                return $"{Caster} cast a weak {Essence}!";
            }
        }
    }
}
