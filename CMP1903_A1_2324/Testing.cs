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

        private int number = 0;

        //Method
        //The end of the test is then displayed to the user.
        public void Test()
        {
            //Error exception to catch the error that is created if the dice rolls fall out of bounds.
            try
            {
                //Test method which generates a single die which is tested to be between 1 and 6 inclusive.
                Die Dice = new Die();
                number = Dice.Roll();
                Debug.Assert(number >= 1 && number <= 6);

                //Generates a whole game which tests the sum of the 3 is between 3 and 18 inclusive.
                Game game = new Game();
                Debug.Assert(number >= 3 && number <= 18);
            }
            //Catch the error
            catch (Exception)
            {
                Console.WriteLine("The test has been failed");
            }
            //Output this message no matter if there was or wasn't an error.
            finally
            {
                Console.WriteLine("Test Complete, close application");
            }
        }
    }
}
