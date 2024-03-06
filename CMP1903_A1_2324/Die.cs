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

        // Property to hold the current die value
        public int FaceValue { get; private set; }

        // Method to roll the die and return the face value
        public int Roll()
        {
            Random random = new Random();
            FaceValue = random.Next(1, 7); // Generate a random number between 1 and 6
            return FaceValue;
        }
    }
}
