using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private int Sum = 0;
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        //Methods
        public int Build()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            int numberOne = die1.Generate();
            Console.WriteLine($"Dice One: {numberOne}");
            int numberTwo = die2.Generate();
            Console.WriteLine($"Dice Two: {numberTwo}");
            int numberThree = die3.Generate();
            Console.WriteLine($"Dice Three: {numberThree}");
            Sum = numberOne + numberTwo + numberThree;
            return Sum;
        }

    }
}
