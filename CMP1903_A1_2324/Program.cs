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
            //create a Game object and call its methods
            Game game = new Game();
            int total = game.RollTotal();
            Console.WriteLine("total of three dice rolls: " + total);
            Console.ReadLine();

            // create a Testing object to verify the output and operation of the classes
            Testing testing = new Testing();
            testing.TestDieGame();

            Console.Write("\n\nAll Test cases passes !!\nTesting sucessfull...");
            Console.ReadLine();
        }
    }
}
      
