using System;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Represents a game instance with a total sum of die rolls.
    /// </summary>
    internal class Game
    {
        // Property to hold the total sum of the die rolls
        public int Sum { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Game"/> class with the sum of die rolls.
        /// </summary>
        /// <param name="rollValue1">Value rolled on the first die.</param>
        /// <param name="rollValue2">Value rolled on the second die.</param>
        /// <param name="rollValue3">Value rolled on the third die.</param>
        public Game(int rollValue1, int rollValue2, int rollValue3)
        {
            Sum = rollValue1 + rollValue2 + rollValue3; // Calculate the total sum of die rolls
        }
    }
}
