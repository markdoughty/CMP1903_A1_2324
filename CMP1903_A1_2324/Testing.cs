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
        Game GameTest = new Game();
        Die DiceTest = new Die();
        int TestDice1 = 0;
        int TestDice2 = 0;
        int TestDice3 = 0;
        public void Test()
        {
            TestDice1 = DiceTest.Roll1();
            TestDice2 = DiceTest.Roll2();
            TestDice3 = DiceTest.Roll3();
            Debug.Assert();
            Debug.Assert();
        }
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
    }
}
