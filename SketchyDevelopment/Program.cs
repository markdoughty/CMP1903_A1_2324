using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("this is text LOL 2");
            Game game = new Game();                 // Create a Game object and call its methods.
            game.Play();
            Console.WriteLine("And now for a continuous game:");
            game.PlayContinuous();
            Console.WriteLine("Continuous game has finished");

            Testing testing = new Testing();        // Create a Testing object to verify the output
                                                    //  and operation of the other classes.
            testing.TestDice();                     // tests if Dice.Roll() is functioning as
                                                    // intended
            testing.TestSum();                      // checks the sum returned by Game.Play() is
                                                    // functioning as intended
            Console.WriteLine("<PRESS ENTER TO EXIT>");
            Console.ReadLine();                     // keeps window open
        }
    }
}
