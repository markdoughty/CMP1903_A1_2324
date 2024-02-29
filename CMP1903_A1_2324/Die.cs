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

        public int StoreValue { get; private set; } //to store the value gotten from rolling the dice

        public int Roll()
        {
            Random random = new Random();
            StoreValue = random.Next(1, 7);
            return StoreValue;
        }
    }
}
