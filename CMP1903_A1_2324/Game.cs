using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Die[] dice;

        // This is the constructor.
        public Game()
        {
            // This Creates the three die objects.
            dice = new Die[3];
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die();
            }
        }

        // This part of the code rolls the dice and then calculates the sum, reporting the total.
        public int RollAndReportTotal()
        {
            int total = 0;
            foreach (Die die in dice)
            {
                die.Roll(); // This rolls each of the die.
                total += die.FaceValue; // This adds the current face value of the die to the total.
            }
            return total;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // This creates a new instance of the Game itself.
            Game game = new Game();

            // This rolls the dice and reports the total value.
            int total = game.RollAndReportTotal();

            // Displays the total value.
            Console.WriteLine("The total of the three dice rolls is: " + total);
        }
    }
}
