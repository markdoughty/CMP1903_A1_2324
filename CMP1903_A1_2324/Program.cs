using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialise the game and output the sum for the user 
            Game game = new Game();
<<<<<<< HEAD
            int amount = game.Sum();
            Console.WriteLine("the total of the three rolled values are " + amount);
=======
            
            
>>>>>>> master

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
