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

        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();

        public void rolling()
        {
            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();
            System.Console.WriteLine("Roll 1 is" + roll1);
            System.Console.WriteLine("Roll 2 is" + roll2);
            System.Console.WriteLine("Roll 3 is" + roll3);
            System.Console.WriteLine("Your total is" + (roll1 + roll2 + roll3) );


        }

        
    }
}
