using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Method to test the Die and Game classes
        public static void Test()
        {
            Game game = new Game();
            game.RollDiceAndReportTotal();

            // Testing die rolls are between 1 and 6 (inclusive)
            for (int i = 0; i < 100; i++)
            {
                Die die = new Die();
                int faceValue = die.Roll();
                Debug.Assert(faceValue >= 1 && faceValue <= 6, "Die roll is out of range.");
            }

            // Testing the sum of the three values
            Debug.Assert(game.Total >= 3 && game.Total <= 18, "Total sum of three dice rolls is out of expected range.");
        }
    }
}