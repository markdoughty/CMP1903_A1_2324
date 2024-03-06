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
        //Test method which generates a single die which is tested to be between 1 and 6 inclusive
        //Generates a whole game which tests the sum of the 3 is between 3 and 18 inclusive.
        //The end of the test is then displayed to the user.
        public void Test()
        {
            try
            {
                Die die = new Die();
                number = die.Generate();
                Debug.Assert(number >= 1 && number <= 6);

                Game game = new Game();
                Debug.Assert(number >= 3 && number <= 18);
            }
            catch (Exception)
            {
                Console.WriteLine("The test has been failed");
            }
            finally
            {
                Console.WriteLine("Test Complete, close application");
            }
        }
    }
}
