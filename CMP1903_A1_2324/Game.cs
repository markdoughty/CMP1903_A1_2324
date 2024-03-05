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
        Die die = new Die();
        int rollNum1;
        int rollNum2;
        int rollNum3;
        int[] rolls;

        public Game()
        {
            // Rolling each dice
            // Time in-between each roll allows for the seed for the random number to be different
            rollNum1 = die.Roll();
            Thread.Sleep(1);
            rollNum2 = die.Roll();
            Thread.Sleep(1);
            rollNum3 = die.Roll();
            rolls = new int[] { rollNum1, rollNum2, rollNum3 };
        }

        //Methods

    }
}
