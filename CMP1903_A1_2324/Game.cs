using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public Die dice1 = new Die();
        public Die dice2 = new Die();
        public Die dice3 = new Die();

        int DiceTotal = 0;

        public void RollDice()
        {
            dice1.DiceNum = dice1.Roll();
            dice2.DiceNum = dice2.Roll();
            dice3.DiceNum = dice3.Roll();
            DiceTotal = dice1.DiceNum + dice2.DiceNum + dice3.DiceNum;
            int DiceSum = dice1.DiceNum + dice2.DiceNum + dice3.DiceNum;
            Console.WriteLine("The first dice rolled a " + dice1);
            Console.WriteLine("the secind dice rolled a " + dice2);
            Console.WriteLine("The third dice rolled a " + dice3);
            Console.WriteLine("The sum of the three dice is" + DiceSum);
            Console.WriteLine("The total of every dice roll is " + DiceTotal);

        }
        public void ReRoll()
        {
            Console.WriteLine("To re-roll the dice type 're-roll'");
            Console.WriteLine("To close the program type 'end'");
            Console.WriteLine("Any other user input will not be accepted");
            bool loop = true;
            while (loop == true)
            {
                string UserInput = Console.ReadLine();
                if (UserInput == "re-roll")
                {
                    RollDice();
                }
                else if (UserInput == "end")
                {
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Only 're-roll' and 'end' are accepted inputs");
                }
            }
            
        }
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

    }
}
