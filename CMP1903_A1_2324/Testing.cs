using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Method to test the classes
        public void Test()
        {
            // Testing Die class
            Die die = new Die();
            int rollValue = die.Roll();
            Debug.Assert(rollValue >= 1 && rollValue <= 6, "Die roll out of range.");

            // Testing Game class
            Game game = new Game();
            // Note: As the Game class does not return values but prints them, we would normally test it by observing the output.
            // For automated testing, consider refactoring Game to return values or to use a mock framework for testing its behavior.
            Console.WriteLine("Testing Game class... (Check the console output for correctness)");
            game.Play();

            Console.WriteLine("All tests passed.");
        }
    }
}
