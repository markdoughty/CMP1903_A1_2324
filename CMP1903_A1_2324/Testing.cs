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
        //Properties
        private int total;

        public Testing() //Constructor method to test other classes
        {
            Die die = new Die();
            int roll = die.Roll();
            Debug.Assert(roll < 7, "Roll value > 6."); //Ensures die roll is within 1-6.
            Debug.Assert(roll > 0, "Roll value < 0.");

            Game game = new Game();
            game.RollDie();
            total = game.roll1 + game.roll2 + game.roll3; //Ensures sum of rolls = the output of the game class.
            Debug.Assert(total == game.total);
        }
    }
}
