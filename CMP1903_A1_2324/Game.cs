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
        //make the rolls continous and the totals and other statistics could be summarised
        public void rollDice()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();
            die1.dieRoll();
            die2.dieRoll();
            die3.dieRoll();
            int total = die1.dieValue + die2.dieValue + die3.dieValue;

            Console.WriteLine("The total of the three dice rolls is: " + total);
        }

       
    }
}
