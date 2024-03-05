using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Property to hold the current die value
        public int Value { get; private set; }

        // Constructor to initialize the die with a default value
        public Die()
        {
            Roll(); // Initialize with a random value
        }

        // Method to roll the die
        public int Roll()
        {
            Random random = new Random();
            Value = random.Next(1, 7); // Generates a number between 1 and 6
            return Value;
        }
    }
}
