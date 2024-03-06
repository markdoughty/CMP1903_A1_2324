using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Represents a die with faces numbered from 1 to 6.
    /// </summary>
    internal class Die
    {
        // Property to hold the current die value
        private int Roll_Value { get; set; } // Getters and Setters for Encapsulation
        // List of possible faces of the die
        private List<int> _dieFaces = new List<int> { 1, 2, 3, 4, 5, 6 };
        // Random number generator
        private static Random random = new Random();

        /// <summary>
        /// Rolls the die and returns the result.
        /// </summary>
        public int Roll()
        {
            // Generate a random index to select a face from the list of die faces
            int i = random.Next(_dieFaces.Count);
            Roll_Value = _dieFaces[i]; // Assign the rolled value to the Roll_Value property
            return Roll_Value; // Returns the rolled value
        }
    }

    /// <summary>
    /// Represents a dice roller that allows continuous rolling of dice.
    /// </summary>
    internal class DiceRoller
    {
        // List to store the rolls
        private List<int> Rolls = new List<int>();
        // Sum of all rolls
        private int SumOfRolls = 0;

        /// <summary>
        /// Rolls the dice continuously until the user chooses to stop by typing 'n' or 'no'
        /// </summary>
        public void RollContinuous()
        {
            while (true)
            {
                Die die = new Die(); // Create a new instance of the Die class
                int rollValue = die.Roll(); // Roll the die and get the roll value
                Rolls.Add(rollValue); // Add the roll value to the list of rolls
                Console.WriteLine("You rolled a: " + rollValue); // Display the roll value to the user

                SumOfRolls += rollValue; // Add the roll value to the total sum

                Console.WriteLine("Do you want to roll again? (Y/N):"); // Prompt the user to roll again
                string choice = Console.ReadLine().ToUpper(); // Read the user's choice
                if (choice == "N" || choice == "n")
                    break; // Exit the loop if the user chooses not to roll again
            }

            SummarizeResults(); // Summarize the results after all rolls
        }

        /// <summary>
        /// Summarizes the results of all rolls, calculates the total sum, and prints the average roll.
        /// </summary>
        private void SummarizeResults()
        {
            Console.WriteLine("Summary of Rolls:");
            foreach (int roll in Rolls)
            {
                Console.WriteLine(roll); // Display each roll value
            }
            Console.WriteLine("Total Sum: " + SumOfRolls); // Display the total sum of all rolls

            // Calculate and print the average roll
            double averageRoll = (double)SumOfRolls / Rolls.Count;
            Console.WriteLine("Average Roll: " + averageRoll);

            // Call WriteToFile method to write the summary to a file
            Print.WriteToFile(Rolls.ToArray(), SumOfRolls);
        }
    }
}
