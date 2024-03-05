using System;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a Game object and calling its methods
            Game game = new Game();
            game.Play();

            // Creating a Testing object to verify the output and operation of the other classes
            Testing testing = new Testing();
            testing.Test();
        }
    }
}
