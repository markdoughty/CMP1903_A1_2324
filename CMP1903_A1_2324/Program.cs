using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            /// <summary> Main method. </summary>
            /// <remarks> Creates a Game object and calls its methods. Creates a Testing object to verify the output and operation of the other classes. </remarks>
            /// <param name="game"> The game object. </param>
            /// <param name="test"> The testing object. </param>
            /// <param name="x"> The amount of dice to roll. </param>
            /// <param name="game"> The game object. </param>

            Game game = new Game();
            Testing test = new Testing();

            Console.WriteLine("How many dice would you like to roll..?");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
            
            test.testDie();
            game.rollDice(x);
            
            Console.ReadKey();
            
        }
    }

}
