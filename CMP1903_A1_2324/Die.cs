using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Die

    {
        private int currentValue;
        private Random random;

        // The Die constructor initialises the random number generator. Each new instance of the die class will be generated with its own independent "random".
        public Die()
        {
            random = new Random();
        }

        // Method that rolls the die and return the result
        public int Roll()
        {
            // Generates a random number between 1 and 6. Next is a method of the Random class in .Net
            currentValue = random.Next(1, 7); // Numbers generated are stored in the currentValue variable.
            return currentValue;
        }

        // Gets the current value of the die
        public int CurrentValue
        {
            get { return currentValue; }
        }
    }
}