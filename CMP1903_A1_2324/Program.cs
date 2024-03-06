using System;
using System.IO;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Main class responsible for user interaction and control flow.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point of the program.
        /// </summary>
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

    /// <summary>
    /// Class responsible for printing output to console and file.
    /// </summary>
    internal class Print
    {
        /// <summary>
        /// Writes the specified text to the console.
        /// </summary>
        public static void Write(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Writes the summary of rolls, total sum, and average roll to a file.
        /// "rolls" Array containing the individual roll values.
        /// "totalSum" Total sum of all roll values.
        /// </summary>
        public static void WriteToFile(int[] rolls, int totalSum)
        {
            string filePath = "output.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    writer.WriteLine("Summary of Rolls:");
                    foreach (int roll in rolls)
                    {
                        writer.WriteLine(roll);
                    }
                    writer.WriteLine("Total Sum: " + totalSum);
                    // Format the average roll to 2 decimal places
                    double averageRoll = (double)totalSum / rolls.Length;
                    writer.WriteLine("Average Roll: " + averageRoll.ToString("F2"));
                }
                Console.WriteLine($"Data written to file {filePath}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    }
}
