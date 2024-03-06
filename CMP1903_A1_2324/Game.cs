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
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        private int sum = 0;
        //Methods
        //Use the die constructor to create 3 different die which each generate a random number
        //These are then displayed to the console, summed, returned and the sum is also displayed.
        public int Build()
        {
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            int numberOne = die1.Roll();
            Console.WriteLine($"Dice One: {numberOne}");

            int numberTwo = die2.Roll();
            Console.WriteLine($"Dice Two: {numberTwo}");

            int numberThree = die3.Roll();
            Console.WriteLine($"Dice Three: {numberThree}");

            sum = numberOne + numberTwo + numberThree;

            return sum;
        }
    }
}
