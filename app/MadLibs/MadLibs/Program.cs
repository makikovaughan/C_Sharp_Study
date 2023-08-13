// See https://aka.ms/new-console-template for more information
using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program writes a Mad Libs word game. Mad Libs are short stories with blanks for the player to fill in that represent different parts of speech. The end result is a really hilarious and strange story.
            Author: Makiko Vaughan
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Welcome to Mad Libs Game! \n Have Fun :)");

            // Give the Mad Lib a title:
            string title = "TRAVELING";

            Console.WriteLine(title);
            // Define user input and variables:

            //Get the user's name
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            //Get the first adjective
            Console.WriteLine("Enter the first adjective.");
            string adj1 = Console.ReadLine();

            //Get the 2nd adjective
            Console.WriteLine("Enter the 2nd adjective.");
            string adj2 = Console.ReadLine();

            //Get the 3rd adjective
            Console.WriteLine("Enter the 3rd adjective.");
            string adj3 = Console.ReadLine();

            //Get a verb
            Console.WriteLine("Enter a verb.");
            string verb = Console.ReadLine();

            //Get the first noun
            Console.WriteLine("Enter the first noun.");
            string noun1 = Console.ReadLine();

            //Get the 2nd noun
            Console.WriteLine("Enter the 2nd noun.");
            string noun2 = Console.ReadLine();

            //Get the animal
            Console.WriteLine("Enter an animal.");
            string animal = Console.ReadLine();

            //Get a food
            Console.WriteLine("Enter a food");
            string food = Console.ReadLine();

            //Get a fruit
            Console.WriteLine("Enter a fruit");
            string fruit = Console.ReadLine();

            //Get a superhero
            Console.WriteLine("Enter a superhero");
            string superHero = Console.ReadLine();

            //Get a country
            Console.WriteLine("Enter a country");
            string country = Console.ReadLine();

            //Get a desert
            Console.WriteLine("Enter a desert");
            string desert = Console.ReadLine();

            //Get a year
            Console.WriteLine("Type a year");
            int year = Convert.ToInt32(Console.ReadLine());

            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superHero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {desert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}

