using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Die {
        /// <Value>
        /// The Die class should contain one property to hold the current die value.
        /// </value>
        private int _value;
        /// <summary>
        /// method that rolls the die, returns and integer and takes no parameters.
        /// </summary>
        /// <returns>
        /// Returns the new value of the die (an intager between 1 and 6 inclusive)
        /// </returns>
        public int Roll() {
            Random random = new Random();
            Thread.Sleep(10);                       // Wait 10 miliseconds, so compiler doesn't
                                                    // assign them all the same number
            _value = random.Next(1, 7);             // Sets "_value" to a random number between 1
                                                    // and 6
            return _value;
        }
        /// <summary>
        /// This is the get-set method for int "_value", allowing external code to access the die
        /// value, but also protecting "_value" by making sure that any attempt to change the its
        /// value is legal ("_value" is only allowed to be a number between 1 and 6)
        /// </summary>
        /// <returns>
        /// the get will return the value of "_value" (an intager between 1 and 6)
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Will raise an "ArgumentOutOfRangeException" if you attempt to set "_value" to a number outside
        /// the allowed 1 to 6 range
        /// </exception>
        public int Value {
            get {
                return _value;
            }
            set {
                if (value >= 1 && value <= 6) {     // if the input value is between 1 and 6,
                                                    // accept it (set "_value" to that value)
                    _value = value;
                }
                else {                              // else raise an exception
                    throw new ArgumentOutOfRangeException($"ERROR: the dice number can only be set to a number between 1 and 6, \"{value}\" was not accepted.");
                }
            }
        }
    }
}
