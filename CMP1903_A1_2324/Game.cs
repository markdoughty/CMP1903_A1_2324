using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Method to roll three dice and report the total
        public void RollThreeDice()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();

            int total = roll1 + roll2 + roll3;

            Console.WriteLine("Total of Three Dice Rolls: " + total);
        }

        // Main method
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.RollThreeDice();
        }
    }
}
