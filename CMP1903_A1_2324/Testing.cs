using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {

        public void TestGame()  //Runs the game method and dice method
        {
            Console.WriteLine("Testing Game Object");
            Game game = new Game(); //Creates a new Game object called game
            game.Play();
            Debug.Assert(2<game.FinalSum && game.FinalSum < 25 ); //Checks that the final sum is possilbe one 3 6 sided dice
            
            Console.WriteLine("Testing Dice Object");
            Dice dice = new Dice(); //Creates a new Dice object called dice
            dice.RollDie();
            Debug.Assert(0<dice.FinalDie&&dice.FinalDie<7); //Checks that the dice rolls between 1 and 6
        }

    }
}
