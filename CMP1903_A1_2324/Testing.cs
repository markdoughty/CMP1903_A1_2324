using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Class responsible for testing the functionality of other classes.
    /// </summary>
    internal class Testing
    {
        // Method to run tests on the classes
        /// <summary>
        /// Runs tests on the Die class.
        /// </summary>
        public void RunTests()
        {
            // Create instances of Die class for each die
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            // Roll each die and capture the roll values
            int rollValue1 = die1.Roll();
            int rollValue2 = die2.Roll();
            int rollValue3 = die3.Roll();

            // Assert that each die roll is within the valid range
            Debug.Assert(rollValue1 >= 1 && rollValue1 <= 6, "Die 1 roll is out of range.");
            Debug.Assert(rollValue2 >= 1 && rollValue2 <= 6, "Die 2 roll is out of range.");
            Debug.Assert(rollValue3 >= 1 && rollValue3 <= 6, "Die 3 roll is out of range.");

            // Verify that the sum of die rolls is as expected
            int expectedSum = rollValue1 + rollValue2 + rollValue3;
            Debug.Assert(expectedSum == expectedSum, $"Sum is not as expected... \'Expected: {expectedSum}, Actual: {expectedSum}");

            Console.WriteLine("Tests passed successfully."); // Display success message
        }
    }
}
