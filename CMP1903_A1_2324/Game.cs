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

        private Die _die1 = new Die();
        private Die _die2 = new Die();
        private Die _die3 = new Die();

        public void gameRoll()
        {
            int roll1 = _die1.Roll();
            int roll2 = _die2.Roll();
            int roll3 = _die3.Roll();
            Console.WriteLine($"roll 1 = {roll1}\nroll 2 = {roll2}\nroll 3 = {roll3}\nsum = {roll1 + roll2 + roll3}");
        }
 
    }
}
