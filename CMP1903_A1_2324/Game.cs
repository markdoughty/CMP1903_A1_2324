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
        /// Initializes a new instance of the Game class with the sum of die rolls.
        /// </summary>
        public Game(int rollValue1, int rollValue2, int rollValue3)
        {
            Sum = rollValue1 + rollValue2 + rollValue3; // Calculate the total sum of die rolls
        }
    }
}
