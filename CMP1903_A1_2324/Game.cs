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
        public int Build()
        {
            //Object instantiation to create 3 seperate die objects.
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            //Roll the 3 seperate die and then display the number they rolled.
            int numberOne = die1.Roll();
            Console.WriteLine($"Dice One: {numberOne}");

            int numberTwo = die2.Roll();
            Console.WriteLine($"Dice Two: {numberTwo}");

            int numberThree = die3.Roll();
            Console.WriteLine($"Dice Three: {numberThree}");

            //Add all of the dice rolls up and then return the value to be used in Program().
            sum = numberOne + numberTwo + numberThree;

            return sum;

            //Proof of encapsulation being used as this line returns an error
            //This is because _number cannot be modified outside the Die class.
            //_number = 0;
        }
    }
}
