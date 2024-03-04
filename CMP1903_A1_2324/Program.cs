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
            //initialise the game and output the sum for the user 
            Game game = new Game();
            int amount = game.Sum();
            Console.WriteLine("the total of the three rolled values are " + amount);

            //test the game works 
            Testing.Testings();

            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Console.ReadKey();
        }
    }
}
