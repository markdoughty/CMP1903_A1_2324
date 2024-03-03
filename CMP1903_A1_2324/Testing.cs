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
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public void test()
        {
            Game testGame = new Game();
            testGame.DieCreation();
            //Console.WriteLine(testGame);

            Die testDie = new Die();
            testDie.diceValue = testDie.Roll();
            Console.WriteLine("Test Roll:  "+testDie.diceValue);
            //debug.assert();
        }
    }
}
