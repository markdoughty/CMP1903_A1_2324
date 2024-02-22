using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        public int DieValue { get; set; }

        //Constructor
        public Die()
        {
            DieValue = 0;
        }

        //Method
        public int Roll()
        {
            var rand = new Random();
            DieValue = rand.Next(1, 7);
            return DieValue;
        }


    }
}
