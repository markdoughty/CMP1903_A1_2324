using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int _dieValue; //creates a private variable for _dieValue, so that it couldn't be used by other c# files linked.
        private static Random rnd = new Random(); //creates a private and static random element, which is only going top be used in one area.
        private static Testing test = new Testing(); //A new object for Testing is created here, so that tests can be made as soon as possible.

        public int DieValue //A public variation of _dieValue is created here, so that it can be used elsewhere.
        {
            get { return _dieValue; } //Returns a value for _dieValue, so that every variation of this object can be unique.
        }

        public void Roll() //Roll method is placed here, in order to generate a value between 1 and 6.
        {
            _dieValue = rnd.Next(1, 7); //Generates a value between 1 and 7 (works with the logic of any number that is: 1, 2, 3, 4, 5, 6 OR value >= 1 and value < 7)
            test.DieTest(_dieValue); //Tests the value that is generated to make sure that the value is truly between 1 and 6.
        }
    }
}
