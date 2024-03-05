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
        //
        public void Test()
        {
            Die die1 = new Die();
            number = die1.Generate();
            Debug.Assert(number >= 1 && number <= 6);

            Game game = new Game();
            Debug.Assert(number >= 3 && number <= 18);

            Console.WriteLine("Test Complete");
        }
    }
}
