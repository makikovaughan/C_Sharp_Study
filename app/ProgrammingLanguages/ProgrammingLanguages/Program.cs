/*
  Project: Programming Languages
  Name: Makiko Vaughan
  In this project lists and LINQ are used to search a database for answers!
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProgrammingLanguages
{
    class Program
    {
        static void Main()
        {
            List<Language> languages = File.ReadAllLines("./languages.txt")
              .Skip(1)
              .Select(line => Language.FromTsv(line))
              .ToList();

            //Call Prettify() to print out the each item
            /*
            foreach(var language in languages){
              Console.WriteLine(language.Prettify());
            } */

            // A query that returns a string for each language. It should include the year, name, and chief developer of each language.
            var historyLanguages = languages
            .Select(l => $"{l.Year}, {l.Name}, {l.ChiefDeveloper}");

            //Render the query result
            /*
            foreach(var historyLanguage in historyLanguages){
              Console.WriteLine(historyLanguage);
            } */

            //A query to find the C#
            var cSharps = languages
            .Where(l => l.Name == "C#");

            //Render the language(s) with the name "C#"
            PrettyPrintAll(cSharps);

            //A query to find all languages invented by Microsoft
            var microsofts = languages
            .Where(l => l.ChiefDeveloper.Contains("Microsoft"));

            //Render the number of languages
            Console.WriteLine(microsofts.Count());

            //A query to find all languages derived from Lisp
            var lispLanguages = languages
            .Where(l => l.Predecessors.Contains("Lisp"));

            //Render the number of languages
            Console.WriteLine(lispLanguages.Count());

            //A query to find all of the language names that contain the word "Script" (capital S). 
            var scriptNames = languages
            .Where(l => l.Name.Contains("Script"))
            .Select(l => l.Name);

            //Render the result
            foreach (var scriptName in scriptNames)
            {
                Console.WriteLine($"Name: {scriptName}");
            }

            //Render the number of languages list
            Console.WriteLine($"There are {languages.Count} languages");

            //A query to count the number of languages launched between 1995 and 2005
            var millenniums = languages
            .Where(l => l.Year >= 1995 && l.Year <= 2005)
            .Select(l => $"{l.Name} was invented in {l.Year}");

            //Render the result
            Console.WriteLine($"The number of languages launched between 1995 and 2005: {millenniums.Count()}");

            //PrintAll(millenniums);

            //Sort the list by Alphabetical order
            var alphabetList = languages
            .OrderBy(l => l.Name);

            //Render the result
            //PrettyPrintAll(alphabetList);

            //A query to find the oldest language in the list
            var oldLanguage = languages
            .Min(l => l.Year);

            //Render the result
            Console.WriteLine(oldLanguage);
        } //Main

        //Method
        //PrettyPrintAll() that handles to print all language list
        public static void PrettyPrintAll(IEnumerable<Language> langs)
        {

            foreach (var lang in langs)
            {
                Console.WriteLine(lang.Prettify());
            }

        }//PrettyPrintAll()

        //PrintAll() to print every object in the argumment
        public static void PrintAll(IEnumerable<Object> langs)
        {

            foreach (Object lang in langs)
            {
                Console.WriteLine(lang);
            }
        } //PrintAll()
    }
}
