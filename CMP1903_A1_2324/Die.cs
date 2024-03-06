using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Property to hold the current die value
        private int Roll_Value { get; set; }
        // List of possible faces of the die
        private List<int> Die_Faces = new List<int> { 1, 2, 3, 4, 5, 6 };
        // Random number generator
        private static Random random = new Random();

        // Method to roll the die
        public int Roll()
        {
            int i = random.Next(Die_Faces.Count);
            Roll_Value = Die_Faces[i];
            return Roll_Value;
        }
    }

    internal class DiceRoller
    {
        // List to store the rolls
        private List<int> Rolls = new List<int>();
        // Sum of all rolls
        private int SumOfRolls = 0;

        // Method to continuously roll dice until user chooses to stop
        public void RollContinuous()
        {
            while (true)
            {
                Die die = new Die();
                int rollValue = die.Roll();
                Rolls.Add(rollValue);
                Console.WriteLine("You rolled a: " + rollValue);

                SumOfRolls += rollValue;

                Console.WriteLine("Do you want to roll again? (Y/N):");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "N" || choice == "n")
                    break;
            }

            SummarizeResults();
        }

        // Method to summarize the results of all rolls
        private void SummarizeResults()
        {
            Console.WriteLine("Summary of Rolls:");
            foreach (int roll in Rolls)
            {
                Console.WriteLine(roll);
            }
            Console.WriteLine("Total Sum: " + SumOfRolls);
            // Calculate and print the average roll
            Console.WriteLine("Average Roll: " + (SumOfRolls / Rolls.Count));
        }
    }
}
