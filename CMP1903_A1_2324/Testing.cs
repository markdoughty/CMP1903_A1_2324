using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.*/
        public void Test()
        {


            Die die = new Die();
            int rollResult = die.Roll();
            Debug.Assert(rollResult >= 1 && rollResult <= 6, "Die roll result is not between 1 and 6");

            Game game = new Game();
            int total = game.RollDiceAndReportTotal();
            Debug.Assert(total >= 3 && total <= 18, "Total of three dice rolls is not between 3 and 18");

            /* Create a Game object, call the methods and compare their output to expected output.
            * Create a Die object and call its method.
            * Use debug.assert() to make the comparisons and tests.
            */
            int expectedDieValue = 5;
            Debug.Assert(rollResult == expectedDieValue, $"Die roll result {rollResult} is not equal to expected value {expectedDieValue}");
            //Method

        }
    }
}