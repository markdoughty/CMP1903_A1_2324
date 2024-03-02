using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Array to hold the three dice
        private Die[] dice = new Die[3];

        // Constructor to initialize the three die objects
        public Game()
        {
            // Initialize each die object
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        // Method to roll all dice and report the total
        public int RollDiceAndSum()
        {
            int total = 0;

            Console.WriteLine("Rolling the dice...");

            // Roll each die and sum the values
            for (int i = 0; i < dice.Length; i++)
            {
                int roll = dice[i].Roll();
                Console.WriteLine($"Die {i + 1} rolled: {roll}");
                total += roll;
            }

            Console.WriteLine($"Total of dice rolls: {total}");

            return total;
        }
    }
}
