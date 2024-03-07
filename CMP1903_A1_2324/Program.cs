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

            //Create a Game object and call its methods.
            Game game = new Game();
            int total = game.RollCombo();
            Console.WriteLine($"Total of all three dice: {total}");

            //Create a Testing object to verify the output and operation of the other classes.

            //Testing the Game
            Testing testGame = new Testing();
            testGame.TestGame();
            //Testing the Dice
            Testing testDie = new Testing();
            testGame.TestDie();

            //To stop the window from closing
            Console.WriteLine("Press the ENTER key to close window...");
            Console.ReadLine();
        }
    }
}
