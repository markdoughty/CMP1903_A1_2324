using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
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

        Game test_game = new Game();

        Die test_die = new Die();
        

        public void test()
        {
            for (int i = 0; i < 50; i++);
            {
                int test_value1 = test_die.roll();

                Debug.Assert(test_value1 < 7 && test_value1 > 1);
            }

        }

        
    }
}
