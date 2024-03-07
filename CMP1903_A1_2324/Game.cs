﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        private int dice1 = 0;
        private int dice2 = 0;
        private int dice3 = 0;

        Die Dice1 = new Die();
        Die Dice2 = new Die();
        Die Dice3 = new Die();

        //Methods
        
        public (int, int, int) Roll_1()
        {
            dice1 = Dice1.dice_roll();
            Console.WriteLine("You rolled a " + dice1);
            
            dice2 = Dice2.dice_roll();
            Console.WriteLine("You rolled a " + dice2);

            dice3 = Dice3.dice_roll();
            Console.WriteLine("You rolled a " + dice3);
            
        }

        public int STotal()
        {
            int Sum = dice1 + dice2 + dice3;
            Console.WriteLine("The sum of the dice is:" + Sum);
            return Sum;
        }
    }
}
