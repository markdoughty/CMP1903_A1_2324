using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            _value = random.Next(1, 6);             // sets "_value" to a random number between 1
                                                    // and 6
            return _value;
        }
        /// <summary>
        /// Method for external classes to get the value of the dice
        /// </summary>
        /// <returns>
        /// Returns the value of the dice (an int between 1 and 6)
        /// </returns>
        public int GetValue() {
            return _value;
        }
    }
}
