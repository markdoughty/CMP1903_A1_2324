
using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // The below property is to hold the current value of die
        public int CurrentValue { get; private set; }

        // There is method to roll the die
        public int Roll()
        {
            // Let's generate a random number between 1 and 6 to simulate a die roll
            Random random = new Random();
            CurrentValue = random.Next(1, 7);

            return CurrentValue;
        }
    }
}
