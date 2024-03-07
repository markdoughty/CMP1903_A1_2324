using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
    internal class Program {
        static void Main(string[] args) {
            Game game = new Game();                 // Create a Game object and call its methods.
            Console.WriteLine("Playing one game:");
            game.Play();
            Console.WriteLine("And now for a continuous game:");
            game.PlayContinuous();
            Console.WriteLine("Continuous game has finished");

            Testing testing = new Testing();        // Create a Testing object to verify the output
                                                    // and operation of the other classes.
            testing.TestDie();                      // tests if Dice.Roll() is functioning as
                                                    // intended
            testing.TestSum();                      // checks the sum returned by Game.Play() is
                                                    // functioning as intended
            Console.WriteLine("<PRESS ENTER TO EXIT>");
            Console.ReadLine();                     // keeps window open
        }
    }
}
/*<Harry Paul> code review:
* code has all functions listed in brief including the optional tasks
* There is a slight logical error in that the die class only rolls between  and 5 due to 
* random.next excluding the end value
* 
* code follows the style guidelines with methods and variables being in the appropriate cases
* and comments formatted correctly
*
* code is easy to read and is thoroughly commented
*
* code handles erroneous inputs from users and prompts them to input something valid
*
* in summary I see no issues with the code. Good Job!
*/