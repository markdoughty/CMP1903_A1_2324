using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public void Test()
        {
            Game gameobj1 = new Game();
            int obj = gameobj1.DiceRoll();
            int sum = gameobj1.Die1.Value + gameobj1.Die2.Value + gameobj1.Die3.Value;

            if (obj == sum)
            {
                Console.WriteLine("obj = sum");
            }
        }

        public void assert(int obj)
        {
            if (obj <= 1 && obj >= 6)
            { Console.WriteLine("the roll of the dice is somewhere between 1 and 6"); }

            else
            {
                Console.WriteLine("the roll of the dice is not within 1 and 6");
            }
        }
        public void debug(int sum)
        {
            if (sum <= 3 && sum >= 18)
            { Console.WriteLine("the sum of the dices is somewhere between 3 and 18"); }

            else
            { Console.WriteLine("the sum of the dices is not within 3 and 18"); }
        }
    }
}
