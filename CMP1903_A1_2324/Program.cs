using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Program
    {

        static void Main(string[] args)
        {
            //Created objects of the Game and Testing classes
            Game game = new Game();
            Testing testing = new Testing();

            //Roll three dices and intialise dice method call
            Console.WriteLine("Rolling three dices");
            game.RollDices();
            game.RollThree();
            Console.WriteLine();

            //Continous rolling method call
            Console.WriteLine("Press Enter to Roll again. Type 'exit' and press Enter to quit");
            game.ContinousDice();

            //Testing the RollDices and RollThree methods
            Console.WriteLine("Tests for the rolling functionality:");
            testing.TestRollDices();
        }
    }
}
