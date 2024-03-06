using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Game object and call its methods
            Game myGame = new Game();
            int totalScore = myGame.Play();

            Console.WriteLine("Total score from the game: " + totalScore);

            // Create a Testing object to verify the output and operation of the other classes
            Testing.TestDie();
            Testing.TestGame();
        }
    }
}


