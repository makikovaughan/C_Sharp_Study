// Pupil.cs
using System;

namespace MagicalInheritance
{
    class Pupil
    {

        //Property
        public string Title
        { get; private set; }

        public string Origin
        { get; private set; }

        //Constructor
        public Pupil(string title)
        {
            Title = title;
            Origin = "wind";
        }

        public Pupil(string title, string origin) : this(title)
        {
            Origin = origin;
        }

        //Method
        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);
        }

        public Storm CastOriginStorm()
        {
            return new Storm(Origin, true, Title);
        }
    }
}
