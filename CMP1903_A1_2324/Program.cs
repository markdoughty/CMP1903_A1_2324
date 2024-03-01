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
            Game game = new Game(); //Creates a new game object
            game.Play(); //Calls the play function for the game object
            
            Testing testing = new Testing();//Creates a new game object
            testing.TestGame(); //Calls the test game function on thr testing object

            Console.ReadLine();

        }
    }
}
