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

        //needs to be accessed by testing class
        public Die one, two, three;
        public int sum;
        public int roll1, roll2, roll3;

        //Methods
        //handles creating die objects, calculating sum and displaying to console
        public void PlayGame()
        {
            //Creates three die objects
            one = new Die();
            two = new Die();
            three = new Die();

            //Tells user to press enter, done to make numbers random as time passes changing the random seed
            Console.WriteLine("Press enter to roll each dice!");

            //Rolls the three dice and records output for testing class
            roll1 = RollDie(one, 1);
            roll2 = RollDie(two, 2);
            roll3 = RollDie(three, 3);

            sum = roll1 + roll2 + roll3;

            //Shows results to user
            Console.WriteLine("The sum is: " + sum + "!!! END\nPress enter to continue...");
            Console.ReadLine();
        }

        //Used to report individual rolls, passing the current die object and its number
        public int RollDie(Die die, int number)
        {
            int roll = die.Roll();

            Console.Write("Die " + number + " rolled: " + roll);
            Console.ReadLine();

            return roll;
        }
    }
}
