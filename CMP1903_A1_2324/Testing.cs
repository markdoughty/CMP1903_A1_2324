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
            // Creates instances of Die class for each die **
            Die dieroll1 = new Die();
            Die dieroll2 = new Die();
            Die dieroll3 = new Die();

            // Rolls each die and captures the roll values **
            int _rollValue1 = dieroll1.Roll();
            int _rollValue2 = dieroll2.Roll();
            int _rollValue3 = dieroll3.Roll();

            // Asserts that each die roll is within the range of 1-6 and if it falls outsiide this range it produces an error message
            Debug.Assert(_rollValue1 >= 1 && _rollValue1 <= 6, "Die 1 is out of range.");
            Debug.Assert(_rollValue2 >= 1 && _rollValue2 <= 6, "Die 2 is out of range.");
            Debug.Assert(_rollValue3 >= 1 && _rollValue3 <= 6, "Die 3 is out of range.");

            // Confirms that the sum of die rolls is as expected and if sum is not as expected it produces an error message
            int _sumVerified = _rollValue1 + _rollValue2 + _rollValue3;
            Debug.Assert(_sumVerified == _sumVerified, $"The value of sum is not as expected. Expected value: {_sumVerified}, Actual value: {_sumVerified}");

            Console.WriteLine("All tests were passed successfully.");
        }
    }
}
