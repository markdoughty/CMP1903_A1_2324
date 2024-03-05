using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public readonly int Roll_Value1 = 0;
        public readonly int Roll_Value2 = 0;
        public readonly int Roll_Value3 = 0;
        public int Sum = 0;



        public Game()
        {


            Die Die1 = new Die();
            Roll_Value1 = Die1.Roll();
            Console.WriteLine(Roll_Value1);

            Die Die2 = new Die();
            Roll_Value2 = Die2.Roll();
            Console.WriteLine(Roll_Value2);

            Die Die3 = new Die();
            Roll_Value3 = Die3.Roll();
            Console.WriteLine(Roll_Value3);

            Sum = Roll_Value1 + Roll_Value2 + Roll_Value3;



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


