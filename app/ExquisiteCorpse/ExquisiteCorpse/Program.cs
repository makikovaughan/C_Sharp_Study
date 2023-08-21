using System;

/*
Project: Exquisite Corp
Name: Makiko Vaughan

In the game Exquisite Corpse, participants draw either a head, body, or feet of a creature. The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.

*/

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test the coding
            //MonsterHead();
            //GhostBody();
            //BugFeet();

            //Test SwitchCase
            //SwitchCase(1, 1, 1);


            //Ask the user to enter information
            Console.WriteLine("You have to choose Ghost, Bug, or Monster for head, body, and feet.");
            Console.WriteLine("Would you like to create randomly or manually?");
            Console.WriteLine("Yes for random. No for manual");

            string startMode = Console.ReadLine().ToUpper();

            //Check if the customer wants to run rondomly or not
            if (startMode == "YES")
            {
                RandomMode();
            }
            else if (startMode == "NO")
            {

                Console.WriteLine("Head:");

                //Get a header choice
                string head = Console.ReadLine();

                //Get a body
                Console.WriteLine("Body:");
                string body = Console.ReadLine();

                //Get feet
                Console.WriteLine("Feet:");
                string feet = Console.ReadLine();

                Console.WriteLine("This is your corpse");
                BuildACreature(head, body, feet);
            }
            else
            {
                Console.WriteLine("Please enter a correct reply");
            }
        }

        //Calls each part of body
        static void BuildACreature(string head, string body, string feet)
        {
            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);

            SwitchCase(headNum, bodyNum, feetNum);
        }

        //Automate a random creature
        static void RandomMode()
        {
            Random randomNumber = new Random();

            //Create three random numbers
            int intHead = randomNumber.Next(1, 4);
            int intBody = randomNumber.Next(1, 4);
            int intFeet = randomNumber.Next(1, 4);
            SwitchCase(intHead, intBody, intFeet);
        }

        //Based on the random number, it displays the head, body, and feet
        static void SwitchCase(int head, int body, int feet)
        {
            //Head
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
                default:
                    Console.WriteLine("Please enter a correct selection");
                    break;
            }

            //body
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
                default:
                    Console.WriteLine("Please enter a correct selection");
                    break;
            }

            //Feet
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
                default:
                    Console.WriteLine("Please enter a correct selection");
                    break;
            }
        }

        //Translate a random number to string
        static int TranslateToNumber(string creature)
        {
            switch (creature.ToLower())
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
