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

            //Sees if each die value matches their recorded roll
            Debug.Assert(testGame.one.Value == testGame.roll1);
            Debug.Assert(testGame.two.Value == testGame.roll2);
            Debug.Assert(testGame.three.Value == testGame.roll3);

            //Sees if die values added up matches the recorded sum
            Debug.Assert(testGame.one.Value + testGame.two.Value + testGame.three.Value == testGame.sum);
        }
    }
}
