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



        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public Game()
        {

            dice = new Die[3];
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die();
            }

        }

        public int DiceTotal()
        {
            int Total = 0;
            foreach (Die die in dice)
            {
                //die.Roll();
                //Total += die.DieTotal;
                Total += die.Roll();
            }

            return Total;


        }

    }
}
