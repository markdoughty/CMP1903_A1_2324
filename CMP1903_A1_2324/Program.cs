using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        //Random rand = new Random((int)DateTime.Now.Ticks);

        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            //Introduction to the program, tells the user what is going to happen
            Console.WriteLine("This is a dice rolling program. First run will be the normal game. Second will run testing die objects.");

            //Normal run of program
            Game game = new Game();
            game.PlayGame();

            //Testing run of program
            Testing testing = new Testing();
            testing.TestGame();

        }
    }
}
