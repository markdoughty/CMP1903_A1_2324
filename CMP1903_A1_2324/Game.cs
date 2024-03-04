using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public void Gameloop()
        {

            //declare var
            int i = 1;
            var list = new List<int> { }; ///List is for calculating the sum.

            /*amountToRoll
            var can be set to any value, and this is how many die will be rolled.*/
            int amountToRoll = 3;
            /*Rolls Dice
            Simple loop while roll the dice x amount of times, adding each roll to a list. */
            while (i <= amountToRoll)
            {
                Die die = new Die();
                Testing debug = new Testing();
                int roll = die.throwDice();
                Console.WriteLine($"Dice " + i + ": " + roll);
                debug.Assert(roll);
                list.Add(roll);
                System.Threading.Thread.Sleep(1); ///Sleep allows program to Create new Object.
                i++;
            }

            /*Print Sum
            Each diceroll in the list will be added to the sum.*/
            Testing sumCheck = new Testing();
            int sum = 0;
            foreach (var item in list) { sum += item; }
            Console.WriteLine($"\nSum: {sum}");
            sumCheck.AssertSum(sum);
        }
    }
}
