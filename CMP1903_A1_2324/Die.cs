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


        //This private integer holds the die's value
        private int _value;

        //Property (needs to be public to be accessed by testing class)
        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        //Method
        //Changes the die's value and returns value of roll to be used in other functions, like to be displayed
        public int Roll()
        {
            //Creates new random with seed based on the computer's clock, to seemingly create random output each use
            Random rand = new Random((int)DateTime.Now.Ticks);
            //Randomly picks value between 1-6
            Value = rand.Next(1, 7);

            return Value;
        }

    }
}
