using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Property to hold the current die value
        public int Value { get; private set; }

        // Constructor to initialize the die with a rolled value
        public Die()
        {
            Roll(); // Initialize with a random value
        }

        // Method to roll the die
        public int Roll()
        {
            // Create a random number generator
            Random random = new Random();

            // Generate a random number between 1 and 6
            Value = random.Next(1, 7);

            // Return the new value
            return Value;
        }
    }
}
