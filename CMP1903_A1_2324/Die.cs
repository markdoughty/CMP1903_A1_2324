using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        static Random r = new Random(); // Instantiates a Random property to produce the random value. Must be a static property or else it will always yield the same value for the three dice.
        //Property
        int Value = 1; // Private integer value as no external scope will be accessing this value.
        //Method
        public int Roll() // Public Roll() method that returns the result as an int. Result is also stored in the Value property.
        {
            Value = r.Next(1, 7); // Calls the method Next() to get a random int from 1 to 6 and assigns the it to the Value property.

            return Value; // Returns the value assigned to Value.
        }
    }
}