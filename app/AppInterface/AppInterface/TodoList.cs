//TodoList representing the to-do list application

using System;

namespace SavingInterface
{
    class TodoList : IDisplayable, IResetable
    {

        //Field
        private string headerSymbol = "--------";

        //Property
        public string[] Todos
        { get; private set; }

        public string HeaderSymbol
        {
            get => headerSymbol;
        }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            try
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
            catch (IndexOutOfRangeException e)
            { //Throw an error if it is more than 5 todos
                throw new ArgumentOutOfRangeException(
                    "It exceeded 5 todos.", e);
            }
        }

        //Render each to-do item
        public void Display()
        {
            Console.WriteLine("Todos");
            Console.WriteLine(HeaderSymbol);
            for (int i = 0; i < Todos.Length; i++)
            {

                //If the list todo is empty, render []
                if (String.IsNullOrEmpty(Todos[i]))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(Todos[i]);
                }
            }
            Console.WriteLine("");
        }

        //Make Todos property to an empty array of length 5
        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

    }
}

