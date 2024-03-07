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
        private Die dice1 = new Die();
        private Die dice2 = new Die();
        private Die dice3 = new Die();
        private int sum = 0;

        int rollingDice()
        {
            int roll1 = dice1.Roll();
            int roll2 = dice2.Roll();
            int roll3 = dice3.Roll();

            Console.WriteLine("roll one = " + roll1);
            Console.WriteLine("roll two = " + roll2);
            Console.WriteLine("roll three = " + roll3);

            Console.WriteLine("the sum of the 3 rolls is = " + sum);
        }
    }
}
