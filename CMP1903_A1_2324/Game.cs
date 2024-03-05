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
        int DieTotal; 

        //Methods


        public int DieSum() 
        {
            Die die = new Die();
            int DieRoll = die.Roll();
            Console.WriteLine("Roll 1: " + DieRoll);

            Die die1 = new Die();
            int DieRoll1 = die.Roll();
            Console.WriteLine("Roll 2: " + DieRoll1);
            
            Die die2 = new Die();
            int DieRoll2 = die.Roll();
            Console.WriteLine("Roll 3: " + DieRoll2);

            int DieTotal = DieRoll + DieRoll1 + DieRoll2;
            Console.WriteLine("Die total: " + DieTotal);

            return DieTotal;
        }
    }
}
