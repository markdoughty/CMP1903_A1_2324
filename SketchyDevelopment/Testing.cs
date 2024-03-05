using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
        public void test_dice()//Tests individual dice
        {
            for (int i=0; i>20; i++)
            {
                Die my_die = new Die();
                for (int a=0; a>20; a++)
                {
                    int output = my_die.Roll();
                    System.Diagnostics.Debug.Assert( output < 1 || output > 6, "Dice value is out of range, expected number from 1--6, instead got \""+output+"\"");
                }
            }
        }
    }
}
