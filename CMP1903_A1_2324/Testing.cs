﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void testGame()
        {
            Die die = new Die();
            int dieValue = die.Roll();
            Debug.Assert(dieValue >= 1 && dieValue <= 6, "The result of the die roll is not between 1 and 6");
            Game game = new Game();
            int total = game.diceGame();
            Debug.Assert(total >= 3 && total <= 18, "The result do not meet the upper and lower bounds.");
        }
    }
}
