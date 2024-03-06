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
            while(true)
            {
                Game game = new Game();
                game.PlayGame();
            }
            /*Game game = new Game();
            game.PlayGame();

            Testing testing = new Testing();*/

        }
    }
}
