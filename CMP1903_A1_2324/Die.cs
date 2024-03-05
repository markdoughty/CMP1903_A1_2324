using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns an integer, and takes no parameters.
         */

        //Property
        private int Roll_Value { get; set; } // Encapsulated
        private List<int> Die_Faces = new List<int> { 1, 2, 3, 4, 5, 6 };
        private static Random random = new Random();

        //Method
        public int Roll()
        {
            int i = random.Next(Die_Faces.Count);
            Roll_Value = Die_Faces[i];
            return Roll_Value;
        }
    }

    internal class DiceRoller
    {
        private List<int> Rolls = new List<int>();
        private int SumOfRolls = 0;

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

        private void SummarizeResults()
        {
            Console.WriteLine("Summary of Rolls:");
            foreach (int roll in Rolls)
            {
                Console.WriteLine(roll);
            }
            Console.WriteLine("Total Sum: " + SumOfRolls);
            Console.WriteLine("Average Roll: " + (SumOfRolls / Rolls.Count));
        }
    }
}