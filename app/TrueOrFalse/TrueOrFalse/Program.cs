/*
  Project: True or False?
  Name: Makiko Vaughan
  In this project, I am building a C# program that presents a quiz the right way: using arrays and loops, it will check the format of user input and repeat the question if the format is incorrect. After the quiz is complete, it will check the user’s responses against the correct answers and present a score.
*/
using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below

            //Creat an array of questions
            string[] questions = { "Is Japan in Asia?", "Is USA in America?", "Is Italy in Africa?" };

            //Creat an array of answers
            bool[] answers = { true, true, false };

            //Call RunQuiz
            RunQuiz(questions, answers);
        } //Main


        //Run quiz
        static void RunQuiz(string[] questions, bool[] answers)
        {

            //Creat an array of responses
            bool[] responses = new bool[questions.Length];

            /* Checks if the length of the questions array IS NOT equal to the length of the answers array. 
            If they are not equal, write a warning to the console. */
            if (questions.Length != answers.Length)
            {
                Console.WriteLine("Warning the number of answers is not equal to the number of questions");
            }
            //Keep track of the question number
            int askingIndex = 0;

            //Iterates each question
            foreach (string question in questions)
            {
                //User input
                string input;

                //true if the user input can be converted to a boolean, otherwise false
                bool isBool = false;

                //the boolean version of the user’s entry
                bool inputBool = false;

                //Keep asking the same question until the user provides the correct answer input
                while (!isBool)
                {
                    //Render a question
                    Console.WriteLine(question);
                    Console.WriteLine("True or false?");

                    //Get the user's intput
                    input = Console.ReadLine();

                    //Convert the user's input to boolean
                    isBool = Boolean.TryParse(input, out inputBool);
                    if (!isBool)
                    {
                        Console.WriteLine("Please respond with 'true' or 'false'.");
                    } //if
                } //while

                //Enter the user's boolean input
                responses[askingIndex] = inputBool;

                //Increment the index
                askingIndex++;
            } //foreach

            //Check responses
            Console.WriteLine(String.Join(", ", responses));

            //to loop through the responses.
            int scoringIndex = 0;

            //to count the number of correct responses. 
            int score = 0;

            //Create a foreach loop that iterates through each answer in answers.
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];

                //Render the user response and correct answer for each answer in answers.
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

                //Increment score if the answer is correct
                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            } //foreach
              //Render the score
            Console.WriteLine($"You got {score} out of {responses.Length} correct!");
        } //RunQuiz
    } //Program
} //TrueOrFalse

