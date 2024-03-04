using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Game
    {
        //makes an object that can interact witht the die class
        private Die[] dicerolled;

        
        public int Sum()
        {
            //hold the sum value and adds the values 
            int total = 0;
            Die roll = new Die();
            Die roll2 = new Die();
            Die roll3 = new Die();
            List<int> rolls = [roll.diceroll(), roll2.diceroll(), roll3.diceroll()];
            foreach (var die in rolls)
            {
                //rolls the dice and gets the value to be added
                total += rolls[die];
            }
            return total;




            /*
             * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
             *
             * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
             * rolls could be continous, and the totals and other statistics could be summarised for example.
             */

            //Methods

        }
    }
}
