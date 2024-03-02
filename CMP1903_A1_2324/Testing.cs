using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Test method for the Die class
        public void TestDie()
        {
            Die die = new Die();
            Console.WriteLine("Testing Die class...");

            // Roll the die and check if the value is within the expected range
            int value = die.Roll();
            Debug.Assert(value >= 1 && value <= 6, "Die roll should be between 1 and 6.");

            Console.WriteLine("Die class passed all tests.");
        }

        // Test method for the Game class
        public void TestGame()
        {
            Game game = new Game();
            Console.WriteLine("Testing Game class...");

            // Roll the dice in the game and check if the total is within the expected range
            int total = game.RollDiceAndSum();
            Debug.Assert(total >= 3 && total <= 18, "Total should be between 3 and 18 (inclusive) for three dice.");

            Console.WriteLine("Game class passed all tests.");
        }

        // General method to run all tests
        public void RunAllTests()
        {
            TestDie();
            TestGame();
        }
    }
}
