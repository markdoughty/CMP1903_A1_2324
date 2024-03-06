using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Property to hold the total sum of the die rolls
        public int Sum { get; private set; }

        // Constructor to initialize the game with the sum of die rolls
        public Game(int rollValue1, int rollValue2, int rollValue3)
        {
            Sum = rollValue1 + rollValue2 + rollValue3;
        }
    }
}
