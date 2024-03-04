using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private static Random DiceValue = new Random(); // Holds current random value


        //Method

        public int Roll()
        {
            // Rolls the dice by creating a random integer value
            return DiceValue.Next(1,7); // Returns a random value
        }


    }
}
