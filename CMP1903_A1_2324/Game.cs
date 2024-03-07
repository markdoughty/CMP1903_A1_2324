using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        private int dice1 = 0;
        private int dice2 = 0;
        private int dice3 = 0;

        Dice Dice1 = new Dice();
        Dice Dice2 = new Dice();
        Dice Dice3 = new Dice();

        //Methods
        
        public (int, int, int) Roll()
        {
            Dicevalue1 = Dice1.Roll():
            Console.WriteLine("You rolled a " + Dicevalue1);
            
            Dicevalue2 = Dice2.Roll():
            Console.WriteLine("You rolled a " + Dicevalue2);

            Dicevalue3 = Dice3.Roll():
            Console.WriteLine("You rolled a " + Dicevalue3);
        }
    }
}
