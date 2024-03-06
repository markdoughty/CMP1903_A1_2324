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

        public Game _testGame = new Game();
        public Die _testDie = new Die();

        //creates a new game and die class

        Debug.Assert(_roll1 >= 1 and _roll1 <= 6);
        Debug.Assert(_roll2 >= 1 and _roll2 <=6);
        Debug.Assert(_roll3 >= 1 and _roll3 <=6);

        //tests boundaries of the roll values to ensure all values are between 1 and 6

        Debug.Assert((_roll1 + _roll2 + _roll3) == Game._dieTotal()); 

        //tests that the sum of the die is as expected
    }
}
