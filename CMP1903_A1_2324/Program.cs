using System;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user whether they want to roll the die more than once
            Console.WriteLine("Do you want to roll the die more than once? (Yes/No):");
            string userInput = Console.ReadLine().ToLower();

            // If user chooses not to roll more than once
            if (userInput == "no" || userInput == "n")
            {
                Die die = new Die();
                int rollValue = die.Roll();
                Console.WriteLine("You Rolled A: " + rollValue);
            }
            // If user chooses to roll more than once
            else if (userInput == "yes" || userInput == "y")
            {
                DiceRoller diceRoller = new DiceRoller();
                diceRoller.RollContinuous();
            }
            // If user provides invalid input
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
            }

            /*
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Testing testing = new Testing();
            testing.RunTests();
        }
    }
}
