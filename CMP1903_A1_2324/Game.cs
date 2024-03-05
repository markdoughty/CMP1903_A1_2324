using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    }
}
