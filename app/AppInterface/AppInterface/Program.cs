/*
  Project: App Interfaces
  Name: Makiko Vaughan
  This program builds some of the standard apps on this new machine, specifically the to-do list and the password manager.
*/

using System;

namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            PasswordManager pm = new PasswordManager("iluvpie", true);

            //Test the TodoList
            tdl.Display();
            tdl.Reset();
            tdl.Display();

            //Test PasswordManager
            pm.Display();
            pm.ChangePassword("iluvpie", "HelloWorld");
            pm.Display();
            pm.Reset();
            pm.Display();

        }
    }
}

