using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private int _die = 0;

        public double DieProperty
        {
            get { return _die; }
            set { _die = RollDie(); }
        }

        //Method

        public static int RollDie ()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 7);
            return value;
        }
    }
}
