using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing.TestDieClass();
            // Create a Game object
            Game game = new Game();

            // Roll the dice
            game.RollDice();

            // Get the list of dice rolls
            var diceRolls = game.GetDiceRolls();

            // Print the dice rolls
            Console.WriteLine("Dice Rolls:");
            foreach (var roll in diceRolls)
            {
                Console.WriteLine(roll);
            }

            // Reports the total of the three dice rolls
            int total = game.ReportTotal();
            Console.WriteLine("Total of the three dice rolls: " + total);
        }
    }
}