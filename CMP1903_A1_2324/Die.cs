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
        private static Testing test = new Testing();

        public int DieValue
        {
            get { return _dieValue; }
        }

        public void Roll()
        {
            _dieValue = rnd.Next(1, 7);
            test.DieTest(_dieValue);
        }

    }
}
