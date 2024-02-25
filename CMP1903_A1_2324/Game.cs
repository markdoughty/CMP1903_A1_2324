using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public int sumtotal = 0;
        //Methods
        public int[] roll3()
        {
            Die Die1 = new Die();
            Die1.Roll();
            Thread.Sleep(1);
            Die Die2 = new Die();
            Die2.Roll();
            Thread.Sleep(1);
            Die Die3 = new Die();
            Die3.Roll();
            int dice1 = Die1.rolledvalue;
            int dice2 = Die2.rolledvalue;
            int dice3 = Die3.rolledvalue;
            Console.WriteLine(Die1.rolledvalue);
            Console.WriteLine(Die2.rolledvalue);
            Console.WriteLine(Die3.rolledvalue);
            int sumtotal += Die1.rolledvalue + Die2.rolledvalue + Die2.rolledvalue;
            Console.WriteLine(sumtotal);
            int[] answers = { sumtotal, dice1, dice2, dice3 };
            return answers;
        }

        public void roll1()
        {
            Die Die1 = new Die();
            Die1.Roll();
            Console.WriteLine(Die1.rolledvalue);
            sumtotal += Die1.rolledvalue;
            Console.WriteLine(sumtotal);
        }
    }
}
