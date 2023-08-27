// Spell.cs
using System;

namespace MagicalInheritance
{
    abstract class Spell
    {

        //Automatic properties
        public string Essence
        { get; protected set; }

        public bool IsStrong
        { get; protected set; }

        public string Caster
        { get; protected set; }

        //Method
        public abstract string Announce();

    }
}

