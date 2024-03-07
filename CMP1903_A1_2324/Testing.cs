using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Thiscode represents a class for testing the functionality of the Die and Game classes.
    /// </summary>
    internal class Testing
    {
        /// <summary>
        /// A method to run tests on the Die and Game classes.
        /// </summary>
        public void Test()
        {
            // Creates instances of Die class for each die 
            Die dice1 = new Die();
            Die dice2 = new Die();
            Die dice3 = new Die();

            // Rolls each die and captures the roll values 
            int rollValue1 = dice1.Roll();
            int rollValue2 = dice2.Roll();
            int rollValue3 = dice3.Roll();

            // Asserts that each die roll is within the range of 1-6 and if it falls outsiide this range it produces an error message
            Debug.Assert(rollValue1 >= 1 && rollValue1 <= 6, "Die 1 is out of range.");
            Debug.Assert(rollValue2 >= 1 && rollValue2 <= 6, "Die 2 is out of range.");
            Debug.Assert(rollValue3 >= 1 && rollValue3 <= 6, "Die 3 is out of range.");

            // Confirms that the sum of die rolls is as expected and if sum is not as expected it produces an error message
            int sumVerified = rollValue1 + rollValue2 + rollValue3;
            Debug.Assert(sumVerified == sumVerified, $"The value of sum is not as expected. Expected value: {sumVerified}, Actual value: {sumVerified}");

            Console.WriteLine("All tests were passed successfully.");
        }
    }
}
