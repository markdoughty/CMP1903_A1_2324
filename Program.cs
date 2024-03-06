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
            Game game = new Game(); /// Creates a new game object
            game.dice_Display(); /// Calls the display dice method

            Testing test = new Testing(); /// Creates a new test object
            test.test_Game(); /// Calls the test game method
            test.test_Die(); /// Calls the test die method 
        }
    }
}
