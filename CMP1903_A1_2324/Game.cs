using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    public class Game
    {
        private List<int> diceRolls;

        public Game()
        {
            diceRolls = new List<int>();
        }

        // Method to roll the dice
        public void RollDice()
        {
            Random random = new Random();
            diceRolls.Clear(); // Clear any previous rolls

            for (int i = 0; i < 3; i++)
            {
                int roll = random.Next(1, 7); // Generate a random number between 1 and 6
                diceRolls.Add(roll); // Store the roll result
            }
        }

        // Method to get the list of dice rolls
        public List<int> GetDiceRolls()
        {
            return diceRolls;
        }
    }
}