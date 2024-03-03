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
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Testing testing = new Testing();
            testing.TestGameRoll();
            testing.TestGameAverage();
            testing.TestDieBounds();

            Game game = new Game();
            int dieRoll3 = game.Roll(3);
            Console.WriteLine($"Rolling 3 dice, the sum is {dieRoll3}");
            int dieRoll4 = game.Roll(4);
            Console.WriteLine($"Rolling 4 dice, the sum is {dieRoll4}");
            Console.WriteLine($"The average die roll is {game.Average}.");
            Console.ReadLine();
        }
    }
}
