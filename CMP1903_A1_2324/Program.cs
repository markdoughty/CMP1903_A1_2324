using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // For WriteToFile exception handling to work.

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Main class responsible for user input and control flow.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point of the program.
        /// </summary>
        static void Main(string[] args)
        {
            // Lets the user choose if they want to roll the die continously or not.
            Console.WriteLine("Do you want to roll the die continously? (Yes/No):");
            string userInput = Console.ReadLine().ToLower();

            // If statement for if the user chooses not to roll continously
            if (userInput == "no" || userInput == "n")
            {
                Die die = new Die(); // Creates a new die roller instances*
                int rollValue1 = die.Roll();
                int rollValue2 = die.Roll();
                int rollValue3 = die.Roll();

                // Output the rolls and their sum
                Console.WriteLine("You Rolled:");
                Console.WriteLine("Roll 1: " + rollValue1);
                Console.WriteLine("Roll 2: " + rollValue2);
                Console.WriteLine("Roll 3: " + rollValue3);
                Console.WriteLine("Sum: " + (rollValue1 + rollValue2 + rollValue3));
            }
            // If user chooses to roll continously.
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


            /// <summary>
            /// Create a Testing object to verify the output and operation of the other classes.
            /// </summary>

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
            catch (IOException ex) // Exception handling
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    }
}
