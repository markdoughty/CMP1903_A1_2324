using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        //Making the three objects
        private Die die1;
        private Die die2;
        private Die die3;

        //Methods

        //Initializing the dice
        public Game()
        {
            die1 = new Die();
            die2 = new Die();
            die3 = new Die();

        }
        public int RollCombo()
        {
            //Rolls
            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();

            //Returning the sum of the three rolls
            int total = roll1 + roll2 + roll3;
            return total;
        }
    }
}
