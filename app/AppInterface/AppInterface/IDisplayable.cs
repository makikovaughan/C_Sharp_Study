// Define IDisplayable in this file

using System;

namespace SavingInterface
{
    interface IDisplayable
    {

        //Property
        string HeaderSymbol { get; }

        //Method
        void Display();
    }
}