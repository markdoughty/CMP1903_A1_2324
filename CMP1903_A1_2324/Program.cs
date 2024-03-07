using System;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// This is the main program class for CMP1903 Assignment 1.
    /// </summary>
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // This prompts the user as to whether they want to roll the die once or numeruous times
            Console.WriteLine("Welcome to my dice roller game! would you like to roll the die more than once? (Yes/No):");
            string userInput = Console.ReadLine().ToLower();

            // If loop for if the user chooses not to roll more than once
            if (userInput == "no" || userInput == "n")
            {
                // Creates a new DiceRoller instance
                DiceRoller _diceRoller = new DiceRoller();

                // Rolls the die three times
                for (int i = 0; i < 3; i++)
                {
                    int _rollValue = _diceRoller.DiceRollOnce();
                    Console.WriteLine("The result of roll " + (i + 1) + " is: " + _rollValue);
                } 

                // This will output the sum of the three rolls
                Console.WriteLine("The sum of all the rolls is: " + _diceRoller.ValueSum());
            }
            // Else If for if the user chooses to roll numeruous times
            else if (userInput == "yes" || userInput == "y")
            {
                // Creates a new DiceRoller instance
                DiceRoller dieRolls = new DiceRoller();

                // Rolls the die continuously until user decides to stop
                dieRolls.ContinuousDieRoller();
            }
            // Else for if user provides invalid input
            else
            {
                Console.WriteLine("That appears to be an invalid input. Please enter 'Yes' or 'No'.");
            }

            /*
             * Creates a new Testing object to verify the output and operation of the other classes.
             */
            Testing testing = new Testing();
            testing.Test();
        }
    }
}
