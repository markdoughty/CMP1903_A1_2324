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
        private int _dieValue;
        private static Random rnd = new Random();

        public int DieValue
        {
            get { return _dieValue; }
            // The setter is optional depending on your design
        }

        public void RollDie()
        {
            _dieValue = rnd.Next(1, 7);
        }

    }
}
