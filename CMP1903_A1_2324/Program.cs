using System;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Game object
            Game game = new Game();

            // Roll the dice and sum their values
            int total = game.RollDiceAndSum();

            // Output the result
            Console.WriteLine($"The total of all dice rolls is: {total}");

            // Assuming a Testing class exists and has a method called VerifyGame
            // Testing testing = new Testing();
            // testing.VerifyGame(game);
            // Note: The above lines would be how you might integrate testing, assuming a corresponding implementation.
        }
    }
}
