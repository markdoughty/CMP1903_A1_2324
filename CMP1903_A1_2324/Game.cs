using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public int RollDice()
        {
            dice1.DiceNum = dice1.Roll1();
            int diceA = dice1.DiceNum;
            dice2.DiceNum = dice2.Roll2();
            int diceB = dice2.DiceNum;
            dice3.DiceNum = dice3.Roll3();
            int diceC = dice3.DiceNum;
            DiceTotal = DiceTotal + diceA + diceB + diceC;
            int DiceSum = diceA + diceB + diceC;
            Console.WriteLine("The first dice rolled a " + diceA);
            Console.WriteLine("the secind dice rolled a " + diceB);
            Console.WriteLine("The third dice rolled a " + diceC);
            Console.WriteLine("The sum of the three dice is " + DiceSum);
            Console.WriteLine("The total of every dice roll is " + DiceTotal);
            string EndGame = ("Game ended, enter anything to close the window");
            string RollAgain = ("Re-rolling dice...");
            string Error = ("Only 're-roll' and 'end' are accepted inputs");
            Console.WriteLine(" ");
            Console.WriteLine("To re-roll the dice type 're-roll'");
            Console.WriteLine("To close the game type 'end'");
            Console.WriteLine("Any other user input will not be accepted");
            bool loop = true;
            while (loop == true)
            {
                string UserInput = Console.ReadLine();
                if (UserInput == "re-roll")
                {
                    Console.WriteLine(RollAgain);
                    Console.WriteLine(" ");
                    RollDice();
                }
                else if (UserInput == "end")
                {
                    Console.WriteLine(EndGame);
                    break;
                }
                else
                {
                    Console.WriteLine(Error);
                }
            }
            return DiceSum;
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
