using System;

/*
  Project: Caesar Cipher
  Programmer: Makiko Vaughan
  This project encrypt and decrypt messages using Caesar Cipher.
*/

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask the user if they want to decrypt or encrypt a message
            Console.WriteLine("Do you want to encrypt or decrypt message?");
            Console.WriteLine("Encrypted: Type E");
            Console.WriteLine("Decrypted: Type D");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "E")
            {
                //Ask the user a secret message and store the message to message.
                Console.WriteLine("Please type a message");
                string message = Console.ReadLine().ToLower();

                //Convert the string to an array of characters
                char[] secretMessage = message.ToCharArray();

                //Store the encrypted message
                char[] encryptedMessage = Encrypt(secretMessage, 3);

                //Render the encryptedMessage      
                Console.WriteLine(String.Join("", encryptedMessage));
            }
            else if (answer == "D")
            {
                Console.WriteLine("Please type a decrypted message");
                string message = Console.ReadLine().ToLower();

                //Convert the string to an array of characters
                char[] secretMessage = message.ToCharArray();

                //Store the encrypted message
                char[] decryptedMessage = Decrypt(secretMessage, 3);

                //Render the encryptedMessage      
                Console.WriteLine(String.Join("", decryptedMessage));
            }
            else
            {
                Console.WriteLine("Please select the correct one");
            }
        }

        //Encrypt() takes a character array and key and returns an encrypted character array .
        static char[] Encrypt(char[] secretMessage, int key)
        {

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //Store the encrypted characters
            char[] encryptedMessage = new char[secretMessage.Length];

            //Check each letter of secret message
            for (int i = 0; i < secretMessage.Length; i++)
            {
                char secretCharacter = secretMessage[i];

                //Find the index of the character
                int index = Array.IndexOf(alphabet, secretCharacter);

                //Add 3 to the letter position
                //Ignore non-alphabet characters
                if (index != -1)
                {
                    index = (index + key) % alphabet.Length;

                    //Get a new secret character
                    secretCharacter = alphabet[index];

                    //Add the encrypted character to the array, encryptedMessage
                    encryptedMessage[i] = secretCharacter;
                }
            }
            return encryptedMessage;
        }

        //Decrypt takes a character array and key and returns a decrypted character array.
        static char[] Decrypt(char[] encryptedMessage, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //Store a decrypted message
            char[] decryptedMessage = new char[encryptedMessage.Length];

            //Check each letter of secret message
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char decryptedCharacter = encryptedMessage[i];

                //Find the index of the character
                int index = Array.IndexOf(alphabet, decryptedCharacter);

                //Subtract 3 to the letter position
                //Ignore non-alphabet characters
                if (index != -1)
                {
                    index = index - key;
                    if (index < 0)
                    {
                        index += alphabet.Length;
                    }

                    //Get a new decrypted character
                    decryptedCharacter = alphabet[index];

                    //Add the decrypted character to the array, decryptedMessage
                    decryptedMessage[i] = decryptedCharacter;
                }
            }
            return decryptedMessage;
        }
    }
}

