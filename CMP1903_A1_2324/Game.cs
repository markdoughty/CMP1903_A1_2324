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
        public void DieGame()
        {
            Die dieOne = new Die();
            dieOne.RollDie();
            int DieOneValue = dieOne.DieValue;

            Die dieTwo = new Die();
            dieTwo.RollDie();
            int DieTwoValue = dieTwo.DieValue;

            Die dieThree = new Die();
            dieThree.RollDie();
            int DieThreeValue = dieThree.DieValue;

            Console.WriteLine($"The sum of three randomly rolled dice is: {DieOneValue + DieTwoValue + DieThreeValue}");
            Console.ReadLine();
        }

    }
}
