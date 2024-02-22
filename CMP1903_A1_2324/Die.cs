using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        static void Main(string[] args)
        {
            int dice = 0;

            Random random = new Random();
            int diceroll = random.Next(1, 7);
            dice = dice + diceroll;

            Console.WriteLine(dice);
        }
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        //Method


    }
}
