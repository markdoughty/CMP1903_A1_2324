using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        public int DiceGame()
        {
            // 3 objects created from Die class
            Die Die = new Die();



            // initiate roll
            int Roll1 = Die.Roll();
            int Roll2 = Die.Roll();
            int Roll3 = Die.Roll();


            // print result
            Console.WriteLine("Die 1: " + Roll1);
            Console.WriteLine("Die 2: " + Roll2);
            Console.WriteLine("Die 3: " + Roll3);

            // sum of 3 dice rolls
            int RollTotal = Roll1 + Roll2 + Roll3;

            // converts total to string so it can be printed
            RollTotal.ToString();

            return RollTotal;


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
