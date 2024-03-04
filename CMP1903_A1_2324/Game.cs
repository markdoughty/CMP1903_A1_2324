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
            foreach (var die in dicerolled)
            {
                //rolls the dice and gets the value to be added
                die.diceroll();
                total += die.fetchvalue();
            }
            return total;
        }
        public Game()
        {
            //loops 3 times and stores the values of the 3 dice and adds to an array for my foreach to work
            dicerolled = new Die[3];
            for (int i = 0; i < 3; i++)
            {
                dicerolled[i] = new Die();
            }
        }
        
        
 
        
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

    }
    
}
