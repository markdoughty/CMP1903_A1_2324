using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Method to play the game
        public void Play()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Rolled: {roll1}, {roll2}, {roll3}");
            Console.WriteLine($"Total: {total}");
        }
    }
}
