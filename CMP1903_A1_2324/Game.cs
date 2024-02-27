using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public int FinalSum //Public variable that sets and gets the private variable sum
        { 
            get { return _sum; }
            set {  _sum = value; }
        }
        private int _sum = 0; //Private variable sum
        public void Play() //Main method for the class
        {
            Dice dice = new Dice(); //Creates a new dice object
            int diceVal = 0;
            
            for (int i = 0;i<=2;i++) //Loops 3 times to roll the dice 3 times and add the number roll to the sum
            {
                diceVal = dice.RollDie(); //Calls the roll die method on the dice objects and the returning integer is set as DieVal
                _sum = _sum + diceVal;
            }
            FinalSum = _sum;
            Console.WriteLine($"The sum of the three dice rolls is {_sum}");
        }

    }
}
