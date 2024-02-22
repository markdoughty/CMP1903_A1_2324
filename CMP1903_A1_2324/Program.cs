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

            Game game = new Game();
            Console.WriteLine("How many dice would you like to roll..?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            game.rollDice(x);
            Console.ReadKey();
            
        }
    }

}
