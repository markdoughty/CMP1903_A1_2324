using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
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
