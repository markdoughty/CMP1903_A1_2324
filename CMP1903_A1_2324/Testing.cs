using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        public static void TestDieClass()
        {
            Die die = new Die();

Development
            // Test Roll method
            Debug.Assert(die.Roll() >= 1 && die.CurrentValue <= 6);

            // Test Roll method multiple times
            for (int i = 0; i < 5; i++)
            {
                int rollResult = die.Roll();
                Console.WriteLine("Roll " + (i + 1) + ": " + rollResult);
                Debug.Assert(rollResult >= 1 && rollResult <= 6, "Result out of range: " + rollResult);

            }
        }
        // Method to test the Game class
        public static void TestGameClass()
        {
            // Create a Game object
            Game game = new Game();

            // Roll the dice
            game.RollDice();

            // Verify that die rolls are between 1 and 6 (inclusive)
            foreach (var roll in game.GetDiceRolls())
            {
                Debug.Assert(roll >= 1 && roll <= 6, "Die roll out of range: " + roll);
            }

            // Verify that the sum of the three values is as expected
            int sum = game.GetDiceRolls().Sum();
            Debug.Assert(sum >= 3 && sum <= 18, "Total sum out of range: " + sum);
        }

        //Method
        //
Development
    }
}