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

        //creates 3 private variables for use ro store the items we roll
        private int _value1;
        private int _value2;
        private int _value3; 

        die die1 = new die();
        die die2 = new die();
        die die3 = new die();
        
        public void game_start()
        {
            _value1 = die1.roll();
            _value2 = die2.roll();
            _value3 = die3.roll();

            public int roll_total = _value1 + _value2 + _value3;
            console.writeline("the numbers you have rolled are " + _value1 ", " + _value2 " and "+ _value3 " which comes to a total of " + roll_total)
        }


    }
}
