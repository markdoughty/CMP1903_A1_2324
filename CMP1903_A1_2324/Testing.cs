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
        public void TestGame()
        {
            //Testing the game class
            Game game = new Game();
            int total = game.RollCombo();
            Debug.Assert(total >= 3 && total <= 18, "Total roll should be within 3 and 18");
        }
        public void TestDie()
        {
            //Testing the die class
            Die die = new Die();
            int roll = die.Roll();
            Debug.Assert(roll >= 1 && roll <= 6, "Single roll should be within 1 and 6");
        }
    }
}
