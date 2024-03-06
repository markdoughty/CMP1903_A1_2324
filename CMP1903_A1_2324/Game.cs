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

        private Die Die1 = new Die(); 
        private Die Die2 = new Die();
        private Die Die3 = new Die();

        //created the three die objects 

        private int Roll1 = Die1.Roll();
        private int Roll2 = Die2.Roll();
        private int Roll3 = Die3.Roll(); 

        //assigned the roll value to each die
        //values assigned to private variables

        public int DieTotal = int Roll1 + int Roll2 + int Roll3;

        //the die values are summed together

        Console.WriteLine($"Die 1 Value: {Roll1}");
        Console.WriteLine($"Die 2 Value: {Roll2}");
        Console.WriteLine($"Die 3 Value: {Roll3}");
        Console.WriteLine($"Total of the three die: {DieTotal}");

        //outputs the values of each die 
        //outputs the sum of all three die

        
    }
}
