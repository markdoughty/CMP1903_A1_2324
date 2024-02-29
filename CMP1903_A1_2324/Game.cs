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

        //Methods

        private int _Total;

        public int Total
        {
            get { return _Total; }
            set
            {
                Die rl = new Die();
                int roll1 = (rl.DieValue);
                int roll2 = (rl.DieValue);
                int roll3 = (rl.DieValue);
                _Total = (roll1 + roll2 + roll3);
            } 
        }
    }

    
}
