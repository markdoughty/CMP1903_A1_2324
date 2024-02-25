using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */



        //Property
        //rolled value property to store what the die rolled
        public int rolledvalue = 0;
        //Method
        public int Roll()
        {
            //create a new random class instance
            Random rnd = new Random();
            //generate a random number
            rolledvalue = rnd.Next(1, 7);
            //return the random number
            return rolledvalue;
        }

    }
}
