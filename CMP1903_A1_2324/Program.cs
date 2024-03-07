using System;

namespace CMP1903_A1_2324
{
    // testActive created to stop console.WriteLine statements in Game class from running twice

    internal class Program
    {
        // new testing variable to check if it is being tested
        public static bool isTesting = false;

        public static void Main(string[] args)
        {

            Testing testing = new Testing();

            // creates play object and starts the game.

            Game play = new Game();
            Console.WriteLine("Total: " + play.DiceGame());
            Console.ReadKey();

        }
    }
}


