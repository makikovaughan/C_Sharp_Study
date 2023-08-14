// See https://aka.ms/new-console-template for more information
using System;

/*
a Money Maker: a program in which a user enters an amount and gets the minimum number of coins that equal that value

Programmed by Makiko Vaughan
*/

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            //Ask the user the value of conversion
            Console.WriteLine("How much cents would you like to convert?");
            string strAmount = Console.ReadLine();

            //Change the input from string to double
            double amount = Math.Floor(Convert.ToDouble(strAmount));

            //Render the input value
            Console.WriteLine($"{amount} cents is equal to...");

            //The value of gold coin
            int goldValue = 10;

            //The value of siver coin
            int silverValue = 5;

            //Calculate the number of gold coins
            double goldCoins = Math.Floor(amount / goldValue);

            //Calculate the number of gold coins
            double remainder = amount % goldValue;
            double silverCoins = Math.Floor(remainder / silverValue);

            //Calculate the blonze coins
            remainder %= silverValue;

            //Render the result
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Blonze coins: {remainder}");
        }
    }
}

