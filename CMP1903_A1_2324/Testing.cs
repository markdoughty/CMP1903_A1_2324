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
        public static void RunTests(Game game)
        {
           

            Debug.Assert(game.Roll_Value1 >= 1 && game.Roll_Value1 <= 6, "Die 1 roll is out of range.");
            Debug.Assert(game.Roll_Value2 >= 1 && game.Roll_Value2 <= 6, "Die 2 roll is out of range.");
            Debug.Assert(game.Roll_Value3 >= 1 && game.Roll_Value3 <= 6, "Die 3 roll is out of range.");

            // Verify that the sum of die rolls is as expected
            int expectedSum = game.Roll_Value1 + game.Roll_Value2 + game.Roll_Value3;
            Debug.Assert(game.Sum == expectedSum, $"Sum is not as expected. Expected: {expectedSum}, Actual: {game.Sum}");


            Console.WriteLine("Tests passed successfully.");
        }

        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        //
    }
}
