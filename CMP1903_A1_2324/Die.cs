using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Represents a six-sided die with methods for rolling and retrieving the roll value(s).
    /// </summary>
    internal class Die
    {
        //This sections holds the value of the dice
        private int _RollsValues { get; set; }
        // Lists faces of the die (1-6) 
        private List<int> _Faces = new List<int> { 1, 2, 3, 4, 5, 6 };
        private static Random random = new Random();

        /// <summary>
        /// Method to roll the die and return the roll value(s). 
        /// </summary>
        public int Roll()
        {
            int i = random.Next(_Faces.Count);
            _RollsValues = _Faces[i];
            return _RollsValues;/// <returns>The value rolled on the die.</returns>
        }
    }

    /// <summary>
    /// This code represents a dice roller with methods used for rolling the die once or continuously, and summarises the results.
    /// </summary>
    internal class DiceRoller
    {
        private List<int> Rolls = new List<int>();
        private int SumOfRolls = 0;

        /// <summary>
        /// A method to roll the die once and update the rolls list and sum.
        /// </summary>
        public int DiceRollOnce()
        {
            Die die = new Die();
            int _valueOfRoll = die.Roll();
            Rolls.Add(_valueOfRoll);
            SumOfRolls += _valueOfRoll;  // Update the sum with each roll
            return _valueOfRoll;  /// <returns>The value rolled on the die.</returns>
        }

        

        /// <summary>
        /// A Method to summarise the results of all rolls
        /// </summary>
        private void DiceRollerSummariseResults()
        {
            Console.WriteLine("Here is the summary of your rolls:");
            foreach (int roll in Rolls)
            {
                Console.WriteLine(roll);
            }
            Console.WriteLine("The total Sum of your rolls is: " + SumOfRolls);
            // Calculates and prints the average roll
            if (Rolls.Count > 0)
            {
                Console.WriteLine("Your average roll was: " + (SumOfRolls / Rolls.Count));
            }
        }

        /// <summary>
        /// A method to continuously roll dice until the user chooses to stop. It will then summarise the results.
        /// </summary>
        public void ContinuousDieRoller()
        {
            while (true)
            {
                int _rollValue = DiceRollOnce();
                Console.WriteLine("You rolled a: " + _rollValue);

                Console.WriteLine("Do you want to roll again? (Y/N):");
                string choice = Console.ReadLine().ToUpper();
                if (choice == "N" || choice == "n")
                    break;
            }

            DiceRollerSummariseResults();
        }

        /// <summary>
        /// A method to get the sum of all rolls.
        /// </summary>
        /// <returns>The sum of all rolls.</returns>
        public int ValueSum()
        {
            return SumOfRolls;  
        }
    }
}

