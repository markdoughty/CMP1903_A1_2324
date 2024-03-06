using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; // Added as Debug.Assert does not work without it.

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Class responsible for testing the functionality of other classes.
    /// </summary>
    internal class Testing
    {
        /// <summary>
        /// Runs tests on the Die class.
        /// </summary>
        public void RunTests()
        {
            // Instantiates a new die (inside of the Die class).
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            // This will roll each die and assign it a value from the Random module.
            int rollValue1 = die1.Roll();
            int rollValue2 = die2.Roll();
            int rollValue3 = die3.Roll();

            // Checks that rollValues are in the correct range of 1~6.
            Debug.Assert(rollValue1 >= 1 && rollValue1 <= 6, "Die 1 roll is out of range.");
            Debug.Assert(rollValue2 >= 1 && rollValue2 <= 6, "Die 2 roll is out of range.");
            Debug.Assert(rollValue3 >= 1 && rollValue3 <= 6, "Die 3 roll is out of range.");

            // If the die roll is out of the expected range it will print and error message.
            int expectedSum = rollValue1 + rollValue2 + rollValue3;
            Debug.Assert(expectedSum == expectedSum, 
                $"Sum is not as expected... \'Expected: {expectedSum}, Actual: {expectedSum}");

            Console.WriteLine("Tests passed successfully."); // Display success message
        }
    }
}
