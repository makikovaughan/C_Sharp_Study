using System;

/*
  Project: Password Checker
  Programmer: Makiko Vaughan
  This project will ask the user to input a password and then check these 
password criterias 
  1. is at least 8 characters long
  2. has lowercase letters
  3. has uppercase letters
  4. has numerical digits
  5. has symbols, like #, ?, !
*/

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

      //a number with the minimum length
      int minLength = 8;

      //a string with all uppercase letters
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

      //a string with all lowercase letters
      string lowercase = "abcdefghijklmnopqrstuvwxyz";

      //a string with all 10 digits
      string digits = "0123456789";

      //a string made of special characters
      string specialChars = "!@#$%^&*()+-=[]{}:;<>/?~`\\,.|\"";

      //if password contains password, the score changes to 0
      string zeroPassword = "password";

      //The password contains 1234, the score changes to 0;
      string zeroDigits = "1234";
      
      //Ask the user to input the password
      Console.WriteLine("Please enter password");

      //Get the input
      string password = Console.ReadLine();

      //Score the user’s password based on the checker
      int score = 0;

      //Add a point if the password length is greater or equal to 8
      if(password.Length >= minLength) {
        score++;
      }

      //Add a point if the password contains uppercase letters
      if(Tools.Contains(password, uppercase)) {
        score++;
      }

      //Add a point if the password contains lowercase letters
      if(Tools.Contains(password, lowercase)) {
        score++;
      }

      //Add a point if the password contains digits
      if(Tools.Contains(password, digits)) {
        score++;
      }

      //Add a point if the password contains special characters
      if(Tools.Contains(password, specialChars)) {
        score++;
      }

      //If the password is password or 1234, change the score to 0
      if(password.ToUpper() == zeroPassword.ToUpper() || password == 
zeroDigits){
        score = 0;
      }

      //Render how the user did for their password
      switch(score) {
        case 5:
        case 4:
          Console.WriteLine($"Points: {score}: The password({password}) is 
extremely strong");
          break;
        case 3:
          Console.WriteLine($"Points: {score}: The password({password}) is 
strong");
          break;
        case 2:
          Console.WriteLine($"Points: {score}: The password({password}) is 
medium");
          break;
        case 1:
           Console.WriteLine($"Points: {score}: The password({password}) 
is weak");
           break;
        default:
          Console.WriteLine($"Points: {score}: The password({password}) 
doesn't meet any of the standards");
          break;
      }

    }
  }
}

