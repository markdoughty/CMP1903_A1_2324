using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
        Game rn = new Game();
    
        public void Main()
        {
            int total = rn.Total(); // Retrives the total of the three die.
            Debug.Assert(total >= 3 && total <= 18, "The total is invalid."); // Checks that the total of all three die are between 3 and 18 as this is the minimum and maximum number the three die should total to.
        }

    }
}
