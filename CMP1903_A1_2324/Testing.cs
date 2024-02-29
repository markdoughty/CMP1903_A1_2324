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

        //Method
        public void DieTest(int value)
        {
            Debug.Assert(value <= 6, "Die generated above the value of 6 (Max)");
            Debug.Assert(value >= 1, "Die generated below the value of 1 (Min)");
        }

        public void GameTest(int value)
        {
            Debug.Assert(value <= 18, "Sum above the value of 18 (Max)");
            Debug.Assert(value >= 3, "Sum below the value of 3 (Min)");
        }

    }
}
