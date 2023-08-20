using System;

/*
  Project: Architect Arithmetic
  Programmer: Makiko Vaughan
  This program creates methods to build a program that calculates the material cost for any architect’s floor plan.
*/

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Test the methods
            //Console.WriteLine(Rectangle(4, 5));
            //Console.WriteLine(Circle(4));
            //Console.WriteLine(Triangle(10, 9));

            //Ask the user to enter the architecture name
            Console.WriteLine("What monument would you like to work with?");
            Console.WriteLine("Theotihuacan, Taj Mahal, or Mosque?");
            string architecture = Console.ReadLine().ToLower();

            switch (architecture)
            {
                case "theotihuacan":
                    Console.WriteLine(CalculateTotalCost());
                    break;
                case "taj mahal":
                    Console.WriteLine(CalculateTotalCostTaj());
                    break;
                case "mosque":
                    Console.WriteLine(CalculateTotalCostMosque());
                    break;
                default:
                    Console.WriteLine("Typo. Please try again");
                    break;
            }
        }

        //Method to calculate the area of rectangle
        static double Rectangle(double width, double length)
        {
            return width * length;
        }

        //Method to calculate the area of circle
        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        //Method to calculate the area of triangle
        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        //Calculate the total cost
        static string CalculateTotalCost()
        {
            //Calculate the area of Theotihuacan
            double totalArea = Rectangle(1500, 2500) + Circle(375) / 2 + Triangle(750, 500);

            //Calculate the cost of flooring material(180 Mexican pesos)
            double cost = totalArea * 180;

            //Return the cost
            return $"The Teotihuacan Cost: {Math.Round(cost, 2)} Mexican pesos";
        }

        //Calculate the total cost of Taj Mahal
        static string CalculateTotalCostTaj()
        {

            //Calculate total area
            double totalArea = Rectangle(90.5, 90.5) - (Rectangle(24, 24) * 4);

            //Calculate the cost
            double cost = totalArea * 180;

            //Return the cost
            return $"The Taj Mahal Cost: {Math.Round(cost, 2)} Mexican pesos";
        }

        //Calcuate the Great Mosque of Mecca
        static string CalculateTotalCostMosque()
        {

            //Calculate area
            double area = Rectangle(180, 106) + Rectangle(284, 264) - Triangle(84, 264);

            //Calculate cost
            double cost = area * 180;

            return $"The Great Mosque of Mecca Cost: {Math.Round(cost, 2)} Mexican pesos";
        }
    }
}


