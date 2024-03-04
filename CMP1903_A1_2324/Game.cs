using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Game
    {
        //makes an object that can interact witht the die class
        


        public int Sum()
        {
            //hold the sum value and adds the values 
            int total = 0;
            Die roll = new Die();
            Die roll2 = new Die();
            Die roll3 = new Die();
            List<int> rolls = [roll.diceroll(), roll2.diceroll(), roll3.diceroll()];
            int i = 0;
            for (i = 0; i < 3;)
            {
                //rolls the dice and gets the value to be added
                Console.WriteLine(rolls[i]);
                total += rolls[i];
                i += 1;

            }
            Console.WriteLine("the total of the three rolled values are " + total);
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
