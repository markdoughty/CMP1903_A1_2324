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

        // Methods

        private Die[] dice;

        public Game()
        {
            dice = new Die[3];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        public int RollDiceAndReportTotal()
        {
            int total = 0;
            foreach (Die die in dice)
            {
                total += die.Roll();
            }
            Console.WriteLine($"Total sum of three dice rolls: {total}");
            return total;
        }
    }
}
