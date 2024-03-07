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

        public Game TestGame = new Game();
        public Die TestDie = new Die();

        //creates a new game and die class

        Debug.Assert(Roll1 >= 1 && Roll1 <= 6);
        Debug.Assert(Roll2 >= 1 && Roll2 <=6);
        Debug.Assert(Roll3 >= 1 && Roll3 <=6);
        Console.Writeline($"Boundary error: Invalid value for the die")

        //tests boundaries of the roll values to ensure all values are between 1 and 6

        Debug.Assert((Roll1 + Roll2 + Roll3) == Game.DieTotal()); 
        Console.Writeline($"Unexpected error: Invalid error for die")

        //tests that the sum of the die is as expected
    }
}
