using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // This is method to test the Game and Die classes
        public void TestGameAndDie()
        {
            // Then test the Die class
            Die die = new Die();
            int dieRoll = die.Roll();

            // Using Debug.Assert to check if the die roll is between 1 and 6
            Debug.Assert(dieRoll >= 1 && dieRoll <= 6, "Die roll is out of expected range");

            // This is created for Testing Game class
            Game game = new Game();
            int totalDiceSum = game.RollAndSumDice();

            // For the Game class, Assert based on the expected rules : The sum of three dice rolls should be between 3 (1+1+1) and 18 (6+6+6)
            Debug.Assert(totalDiceSum >= 3 && totalDiceSum <= 18, "Total dice sum is out of expected range");

            Console.WriteLine("Tests passed successfully!");
        }
    }
}
