/*
  Project: The Object of Your Affection
  Name: Makiko Vaughan
  
  This program builds a pretty well-organized system of dating profiles.

*/
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Sam's profile
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

            //Set Sam's hobbies
            sam.SetHobbies(new string[] { "listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns" });

            //Render Sam's info
            Console.WriteLine(sam.ViewProfile());

            //Create Jane's profile
            Profile jane = new Profile("Jane Doe", 18);
            //jane.Age = 17;

            //Render Jane's info
            Console.WriteLine(jane.ViewProfile());
        }
    }
}


