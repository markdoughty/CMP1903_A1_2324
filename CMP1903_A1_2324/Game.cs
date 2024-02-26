using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public void CreateGame()
        {
            Die dice1 = new Die();
            int roll1 = dice1.RollDice();
            Console.WriteLine($"Roll of dice 1 is {roll1}");

            Die dice2 = new Die();
            int roll2 = dice2.RollDice();
            Console.WriteLine($"Roll of dice 2 is {roll2}");

            Die dice3 = new Die();
            int roll3 = dice3.RollDice();
            Console.WriteLine($"Roll of dice 3 is {roll3}");

            int sum = roll1 + roll2 + roll3;
            Console.WriteLine($"Summation of 3 dice rolls is {sum}");
        }

    }
}
