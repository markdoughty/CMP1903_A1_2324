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
        
        public game_start()
        {
            die roll1 = new die()
            {
                int value = die.roll();
            }
        
            die roll2 = new die()
            {
                int value = die.roll();
            }


            die roll3 = new die()
            {
                int value = die.roll();
            }

             public int roll_total = roll1.die_value + roll2.die_value + roll3.die.value;

        }


    }
}
