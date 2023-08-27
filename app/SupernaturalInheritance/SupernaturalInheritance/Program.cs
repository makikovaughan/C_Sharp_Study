/*
  Project: Supernatural Inheritance
  Name: Makiko Vaughan
  This project develops a system in C# to track the weather magicians in the guild and their spells.

*/
using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create an array of Storm
            Storm[] storms = new Storm[10];
            int stormsIndex = 0;
            //Test Storm
            Storm storm1 = new Storm("wind", false, "Zul'rajas");
            //Console.WriteLine(storm.Announce());  
            storms[stormsIndex] = storm1;
            stormsIndex++;

            //Test Pupil
            Pupil pupil = new Pupil("Mezil-kree");
            //Console.WriteLine(pupil.CastWindStorm().Announce());   
            storms[stormsIndex] = pupil.CastWindStorm();
            stormsIndex++;

            //Test Mage
            Mage mage = new Mage("Gul’dan");
            //Console.WriteLine(mage.CastRainStorm().Announce());
            storms[stormsIndex] = mage.CastRainStorm();
            stormsIndex++;

            //Test Archmage
            Archmage archmage = new Archmage("Nielas Aran");

            Storm rainStorm = archmage.CastRainStorm();
            //Console.WriteLine(rainStorm.Announce());
            storms[stormsIndex] = rainStorm;
            stormsIndex++;
            Storm lightningStorm = archmage.CastLightningStorm();
            //Console.WriteLine(lightningStorm.Announce());
            storms[stormsIndex] = lightningStorm;
            stormsIndex++;

            //Create another pupil
            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            storms[stormsIndex] = p.CastOriginStorm();
            stormsIndex++;

            //Create another mage
            Mage m = new Mage("Gul'dan", "Draenor");
            storms[stormsIndex] = m.CastOriginStorm();
            stormsIndex++;

            //Create another archmage
            Archmage a = new Archmage("Nielas Aran", "Stormwind");
            storms[stormsIndex] = a.CastOriginStorm();
            stormsIndex++;

            for (int i = 0; i < stormsIndex; i++)
            {
                Console.WriteLine(storms[i].Announce());
            }
        }
    }
}