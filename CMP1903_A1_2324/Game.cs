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

        // Rolls the dice
        public void RollDice()
        {
            Random random = new Random();
            diceRolls.Clear(); // Clears any previous rolls

            for (int i = 0; i < 3; i++)
            {
                int roll = random.Next(1, 7); // Generates a random number between 1 and 6
                diceRolls.Add(roll); // Store the roll result
            }
        }

        // Method that gets the list of dice rolls
        public List<int> GetDiceRolls()
        {
            return diceRolls;
        }

        // Method that calculates and report the total of the three dice rolls
        public int ReportTotal()
        {
            int total = diceRolls.Sum(); // Calculate the sum of the dice rolls
            return total;
        }
    }
}