﻿using System;
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

        public void PLay()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();

            int total = roll1 + roll2 + roll3;
                
            Console.WriteLine("die 1 is: " + roll1);
            Console.WriteLine("die 2 is: " + roll2);
            Console.WriteLine("die 3 is: " + roll3);
            Console.WriteLine("total is: " + total);
        }

    }
}
