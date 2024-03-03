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

        /// <summary>
        /// Tests whether die rolls are within 1-6.
        /// </summary>
        public void TestDieBounds()
        {
            Die debugDie = new Die();
            Random rand = new Random();
            
            for (int i = 0; i < 1000; i++)
            {
                int roll = debugDie.Roll(rand);
                Debug.Assert(roll > 0 && roll < 7, "Roll is out of bounds.");
            }
        }

        /// <summary>
        /// Tests if the sum of a 3 dice roll is between 3 (minimum) and 18 (maximum).
        /// </summary>

        public void TestGameRoll()
        {
            Game game = new Game();
            for (int i = 0;i < 1000;i++)
            {
                int sum = game.Roll(3);
                Debug.Assert(sum >= 3 && sum <= 18, "Sum is out of range.");
            }
        }

        /// <summary>
        /// Tests if the average dice roll of a game stays between 1 and 6.
        /// </summary>

        public void TestGameAverage() 
        { 
            Game game = new Game();

            for(int i = 0; i<1000; i++)
            {
                game.Roll(3);
                float average = game.Average;
                Debug.Assert(average >= 1.0f && average <= 6.0f, "Average is out of possible range.");
            }
            
        }
    }
}
