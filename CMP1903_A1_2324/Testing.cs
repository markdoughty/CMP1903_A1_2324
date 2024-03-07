using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    class Testing
    {
        Game game = new Game(); // Instantiate the game class (create an object of the game class)
        
        public void TestRollDices() // Method to test the RollDices method
        {
            game.RollDices(); // Call the RollDices method

            int[] rolls = game.RollThree(); // Call the RollThree method and store the return value in the rolls array

            // Check individual dice rolls
            for (int i = 0; i < rolls.Length; i++)
            {
                Debug.Assert(rolls[i] >= 1 && rolls[i] <= 6, $"Test Failed: {rolls[i]}. Roll should be between 1 and 6."); // Assert that the roll of each dice object is between 1 and 6
            }

            // Check sum of rolls
            CheckSum(rolls);
        }

        private void CheckSum(int[] rolls)
        {
            int sumOfRolls = 0; // Variable to hold the sum of the rolls

            foreach (int roll in rolls) // Loop through the rolls array
            {
                sumOfRolls += roll; // Add the roll of each dice object to the sum of the rolls
            }

            Debug.Assert(sumOfRolls >= 3 && sumOfRolls <= 18, $"Test Failed: {sumOfRolls}. Sum of rolls should be between 3 and 18."); // Assert that the sum of the rolls is between 3 and 18 (inclusive)
        }
    }
}
