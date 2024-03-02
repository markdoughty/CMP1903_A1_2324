using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    /*
        * This class should test the Game and the Die class.
        * Create a Game object, call the methods and compare their output to expected output.
        * Create a Die object and call its method.
        * Use debug.assert() to make the comparisons and tests.
        */

    //Method
    internal class Testing
    {
        Game GameTest = new Game();
        Die DieTest = new Die();

        public void TestDieClass()
        {
            Debug.Assert(DieTest.Roll >= 1 && DieTest.Roll <= 6, "The data type is incorrect or out of range (DieRoll)");
            Debug.Assert(DieTest.Value >= 1 && DieTest.Roll <= 6, "The data type is incorrect or out of range (DieValue)");

        }

        public void TestGameClass()
        {
            Debug.Assert(GameTest.DieSum == GameTest.Die_D1 + GameTest.Die_D2 + GameTest.Die_D3, "Maths Error (DieSum");
            Debug.Assert(GameTest.Round >= 0, "logic error (GameRound");
            Debug.Assert(GameTest.Die_D1 >= 1 && GameTest.Die_D1 <= 6, "return valid not in range or incorrect data type (Die_D1");
            Debug.Assert(GameTest.Die_D2 >= 1 && GameTest.Die_D2 <= 6, "return valid not in range or incorrect data type (Die_D2");
            Debug.Assert(GameTest.Die_D3 >= 1 && GameTest.Die_D3 <= 6, "return valid not in range or incorrect data type (Die_D3");
        }


    }
}