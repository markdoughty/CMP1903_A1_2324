using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Field
        //Initialise variable to store dice rolls in
        private int _number;

        //Property
        //Use encapsulation to protect the dice roll values from being accidentally changed.
        public int number
        {
            get { return _number; }
            set { _number = value; }
        }

        //Method
        //Randomly generates and returns random integers between 1 and 6.
        public int Roll()
        {
            //System must pause between generations otherwise all dice will be the same number.
            Thread.Sleep(500);
            Random rnd = new Random();
            _number = rnd.Next(1, 7);
            return _number;
        }
    }
}
