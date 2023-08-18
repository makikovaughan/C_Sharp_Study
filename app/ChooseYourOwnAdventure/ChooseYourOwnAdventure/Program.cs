using System;

/*
  Project: Choose Your Own Adventure Game
  Name: Makiko Vaughan
  This progrma is a classic text-based Choose Your Own Adventure Game. Depending on what choices your user makes, the program will have a different result.
*/

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");

            //Start our story
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");

            //Ask the user if he/she is yes or no
            Console.WriteLine("Type YES or NO:");

            //Get the input
            string noiseChoice = Console.ReadLine().ToUpper();

            //If the answer is no, then end the adventure
            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
            } //If the answer is yes
            else if (noiseChoice == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\nYou walk towards it. Do you open it or knock?");
                //Ask the user if he/she will open or knock
                Console.Write("Type OPEN or KNOCK:");
                string doorChoice = Console.ReadLine().ToUpper();
                //if the user choses knock
                if (doorChoice == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\" \n\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                    //Ask the user the answer
                    Console.WriteLine("Type your answer:");
                    //Get the input
                    string riddleAnswer = Console.ReadLine().ToUpper();
                    //The correct answer is NOTHING
                    if (riddleAnswer == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.");
                        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
                        Console.WriteLine("THE END.");
                    } //If the answer is not correct
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.");
                        Console.WriteLine("THE END.");
                    }
                } //if the user chooses open
                else if (doorChoice == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if one of your three keys will open it.");

                    //Ask the user to enter a number
                    Console.WriteLine("Enter a number (1-3):");

                    //Get the input
                    string keyChoice = Console.ReadLine().ToUpper();

                    //Check the number
                    switch (keyChoice)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!");
                            Console.WriteLine("The door opens and NOTHING is there. Strange...");
                            Console.WriteLine("THE END.");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.");
                            Console.WriteLine("THE END.");
                            break;
                        default:
                            Console.WriteLine("Please enter a correct key number.");
                            Console.WriteLine("THE END.");
                            break;
                    }
                }
                else
                {
                    //Notify the user that the answer is not correct
                    Console.WriteLine("You did not enter a correct answer. Would you like to continue? YES or NO");
                    string answerChoice = Console.ReadLine().ToUpper();
                    answerChoice = (answerChoice == "YES") ? "Please try again" : "THE END.";
                    Console.WriteLine(answerChoice);
                }
            }
        }
    }
}


