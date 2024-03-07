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
        //Tests each roll and sum to see if the die object's values match the values recorded in the game class
        //Should come up with no error messages if all values match
        public void TestGame()
        {
            //Tells user that they are now on testing run
            Console.WriteLine("Now on the testing run....");

            //Creates new game object
            Game testGame = new Game();
            testGame.PlayGame();

            //Checks each roll to see if between 1-6
            Debug.Assert(1 <= testGame.roll1 && testGame.roll1 <= 6, "roll1 rand value not between 1-6");
            Debug.Assert(1 <= testGame.roll2 && testGame.roll2 <= 6, "roll2 rand value not between 1-6");
            Debug.Assert(1 <= testGame.roll3 && testGame.roll3 <= 6, "roll3 rand value not between 1-6");

            //Sees if each die value matches their recorded roll (added custom error messages)
            Debug.Assert(testGame.one.Value == testGame.roll1, "Die one value mismatch");
            Debug.Assert(testGame.two.Value == testGame.roll2, "Die two value mismatch");
            Debug.Assert(testGame.three.Value == testGame.roll3, "Die three value mismatch");

            //Sees if die values added up matches the recorded sum
            Debug.Assert(testGame.one.Value + testGame.two.Value + testGame.three.Value == testGame.sum, "Sum value mismatch");
        }
    }
}
