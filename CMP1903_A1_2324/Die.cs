using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Dice
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        

        //Property
        static Random rand = new();

        //Method
        public int dice_roll()
        {
            int value = rnd.next(1,7)

            return value
        }

    }
}
