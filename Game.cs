using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  * *******  Instructions ********
 * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
 *
 * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
 * rolls could be continous, and the totals and other statistics could be summarised for example.
 */


namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Die[] dice;
        private List<int> diceRolls;

        public Game()
        {
            dice = new Die[3]; // Creating an array to store the values of the dice rolls
            diceRolls = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die(); // Initialising the new die objects
                diceRolls.Add(dice[i].CurrentValue); // Storing the CurrentValue to the list
            }
        }

        public List<int> GetDiceRoll() //Method
        {
            return diceRolls;
        }

        public int GetTotal() //Method
        {
            int total = 0;
            foreach (var roll in diceRolls) // Summing up all the rolls
            {
                total += roll;
            }
            return total;
        }

        public void Play()
        {
            bool rollAgain = true;
            while (rollAgain)
            {
                Console.WriteLine("DRUM ROLL");
                Console.WriteLine("Dice are being rolled");
                diceRolls.Clear(); // Clearing previous rolls
                foreach (var die in dice)
                {
                    int roll = die.Roll();
                    diceRolls.Add(roll);
                    Console.WriteLine($"Die rolled: {roll}");
                }
                Console.WriteLine($"Total of the dice rolls: {GetTotal()}");

                Console.WriteLine("Would you like to roll again? (Yes/no) (Y/N):"); // asking the user if they would like to re roll their dice
                string input = Console.ReadLine().ToLower();
                rollAgain = (input == "yes" || input == "y");
            }

        }
    }
}
