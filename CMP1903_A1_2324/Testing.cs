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
        private void testDie()
        {
            Die die = new Die();
            int DieResult = die.Roll();

            Debug.Assert(DieResult >= 1 && DieResult <= 6, "invalid Die Value");

            Console.WriteLine($" test die roll result: {DieResult}");
        }

        private void testGame()
        {
            Game game = new Game();
            int Total = game.DiceTotal();
            //int Total = 1;
            Debug.Assert(Total >= 3 && Total <= 18, "invalid roll total");
            Console.WriteLine($" test roll total is {Total}");
        }
        public Testing()
        {
            testDie();
            testGame();
        }
    }
}
