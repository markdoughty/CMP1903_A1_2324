using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int currentValue;
        private Random random;

        public int Value { get { return currentValue; } }

        public Die()
        {
            random = new Random();
            Roll();
        }

        public void Roll()
        {
            currentValue = random.Next(1, 7);
        }
    }
}
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        //Method


    }
}
