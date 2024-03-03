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

        //Methods

        Die diceOne = new Die();
        Die diceTwo = new Die();
        Die diceThree = new Die();
        public void DieCreation()
        {
            diceOne.Roll();
            diceTwo.Roll();
            diceThree.Roll();
            Console.WriteLine("Dice 1: "+ diceOne.diceValue);
            Console.WriteLine("Dice 2: " + diceTwo.diceValue);
            Console.WriteLine("Dice 3: " + diceThree.diceValue);
        }
    }
}
