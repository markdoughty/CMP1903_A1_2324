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
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        
        public void testDie()
        {
            Die die = new Die();

            for (int i = 0; i < 1000; i++)
            {
                int x = die.dieRoll();
                Debug.Assert(x >= 1 && x <= 6, "Die roll is out of range");
            }
        }
        
    }
}
