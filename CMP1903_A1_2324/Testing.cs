using System;
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
        public static void TestGame()
        {
            Game testGame = new Game();
            int TotalValues = testGame.Total;

            Debug.Assert(TotalValues >= 3 && TotalValues <= 18, $"Sum of die values ({TotalValues}) not between 3 and 18"); //Check if the sum of the values is between 3 and 18
            
        }

        public static void TestDie()
        {
            Die testDie = new Die();

            int DieValue = testDie.RollDie();     //roll die and see if value is between 1 and 6
            Debug.Assert(DieValue >= 1 && DieValue <= 6, $"Die roll ({DieValue}) not between 1 and 6");


        }

    }
}
