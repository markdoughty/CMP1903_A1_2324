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
        
        for (int i = 0; i < 1000; i++)        
            {
                Die die = new Die();
                int roll = die.dieRoll();
                Debug.Assert(roll >= 1 && roll <= 6, "Die roll is out of range");
            }
        
    }
}
