
using System;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // At first create a Game object
            Game game = new Game();

            // Here calling the RollAndSumDice method of the Game class
            int totalDiceSum = game.RollAndSumDice();

            // Now creating a Testing object
            Testing testing = new Testing();

            // To call testing methods to verify the output and operation of other classes
            testing.VerifyGameOutput(totalDiceSum);

            Console.ReadLine(); // Keep the console window open(this is optional) 
        }
    }
}
