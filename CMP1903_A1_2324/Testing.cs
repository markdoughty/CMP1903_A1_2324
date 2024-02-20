using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    
    /// <summary>
    /// Class to test the game functionality, make sure values are as expected and use debug.assert() to outline any issues.
    /// </summary>
    
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        /// <summary>
        /// Method to test the game functionality, make sure values are as expected and use debug.assert() to outline any issues.
        /// </summary>
        public void RunTests()
        {
            Game game1 = new Game();
            
            // Test the game functionality in a loop
            for (int i = 0; i < 1000; i++)
            {
                var (sum, roll1, roll2, roll3) = game1.StartGame();
                Debug.Assert(sum == roll1 + roll2 + roll3, "The sum of the dice rolls is not equal to the sum of the individual rolls.");
                Debug.Assert(roll1 >= 1 && roll1 <= 6, "The first roll is not within the expected range.");
                Debug.Assert(roll2 >= 1 && roll2 <= 6, "The second roll is not within the expected range.");
                Debug.Assert(roll3 >= 1 && roll3 <= 6, "The third roll is not within the expected range.");
                Debug.Assert(sum >= 3 && sum <= 18, "The sum of the dice rolls is not within the expected range.");
            }
        }
    }
}
