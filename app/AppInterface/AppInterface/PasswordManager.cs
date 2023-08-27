//PasswordManager representing the password manager.

using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable
    {
        //Fields
        private string password;
        private string headerSymbol;

        //Properties
        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length > 0 && value.Length < 8)
                {
                    password = value;
                    Console.WriteLine("The password length must be at least 8 characters long.");
                }
                else
                {
                    password = value;
                }
            }
        }

        public string HeaderSymbol
        {
            get { return headerSymbol; }
        }

        public bool Hidden
        { get; private set; }

        //Constructor
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
            headerSymbol = "------------";
        }

        //Method

        //Render the password
        public void Display()
        {
            Console.WriteLine("Password");
            Console.WriteLine($"{HeaderSymbol}");
            if (Hidden)
            {
                for (int i = 0; i < Password.Length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine(Password);
            }
            Console.WriteLine("");
        }

        //Reset the password
        public void Reset()
        {
            Password = "";
            Hidden = false;
        }

        //Change password. First parameter: Current Second parameter: New password
        public bool ChangePassword(string password, string newPassword)
        {
            if (Password == password)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}