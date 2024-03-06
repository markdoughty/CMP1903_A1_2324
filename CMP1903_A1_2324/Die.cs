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

        private int _DiceRoll;

        public int DiceRoll { get { return _DiceRoll; } set { _DiceRoll = DiceRoll } }

        //Property


        //Method
        public int Roll()
        {
            Random rnd = new Random();
            int DiceRoll = rnd.Next(1, 7);
            return (DiceRoll);
        }


    }
}
