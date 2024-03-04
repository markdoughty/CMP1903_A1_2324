using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieGame_Assessment_1
{
    // Die Class
    public class Die
    {
        // Stores the random object for number generation
        private Random random;

        // Creates a current value integer to store the value of a die
        public int CurrentValue; 

        // Die class constructor 
        public Die(Random random)
        {
            // Initializes the random object. 
            // Sets the current value of each die to 0
            this.random = random;
            CurrentValue = 0;
        }

        // Method to roll each dice. This will then change the current value to a random number
        public int Roll()
        { 
            CurrentValue = random.Next(1, 7); // Assigns current value to a random number between 1 and 6
            return CurrentValue;
        }
    }
}
