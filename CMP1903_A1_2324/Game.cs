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
        int value1;
        int value2;
        int value3; 

        Die die1 = new Die();
        Die die2 = new Die();
        Die die3 = new Die();
        
        public void game_start()
        {
            value1 = die1.roll();
            value2 = die2.roll();
            value3 = die3.roll();        
            int roll_total = value1 + value2 + value3;
            Console.WriteLine("the numbers you have rolled are " + value1 + ", " + value2 + " and " + value3 + " which comes to a total of " + roll_total);
        }


    }
}
