/*
  Program: Rover Control Center
  Name: Makiko Vaughan
  This program uses references, inheritance, interfaces, and array to manage Rover Control Center.
*/
using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            //Store the three rovers in an array of type Rover[]
            //Rover[] rovers = {lunokhod, apollo, sojourner};

            //Call DirectAll()
            //DirectAll(rovers);

            //Create an array for three rovers and one satellite
            Object[] probesObj = { lunokhod, apollo, sojourner, sputnik };

            //Render the each type in probes
            foreach (Object probe in probesObj)
            {
                Console.WriteLine($"Tracking a {probe.GetType()}...");
            } //foreach

            //Create an array of IDirectable[]
            //IDirectable[] probes = {lunokhod, apollo, sojourner, sputnik};

            //Create an array of Probe
            Probe[] probes = { lunokhod, apollo, sojourner, sputnik };

            //Call DirectAll
            DirectAll(probes);

        } //Main

        //Method
        public static void DirectAll(Probe[] probes)
        {
            foreach (Probe probe in probes)
            {
                Console.WriteLine(probe.GetInfo());
                Console.WriteLine(probe.Explore());
                Console.WriteLine(probe.Collect());
            }
        } //DirectAll
    } //Program
} //RoverControlCenter


