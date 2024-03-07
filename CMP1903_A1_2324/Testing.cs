﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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

        //properties


        //Method
        public static void StartTests()
        {
            Die testingDie = new Die();
            for (int i = 0; i < 1000; i++)
            {
                int var = testingDie.Roll();
                Debug.Assert(var >= 1 && var <= 6, "roll out of range.");
                int testAmount = i;
            }
            Console.WriteLine("1000 tests passed successfully. Continueing program");
        }
    }
}
