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
        
        /// <summary>
        /// Die class to hold the current die value and roll the die.
        /// </summary>

        //Property
        private static Random RND = new Random();
        public int RollVal { get; set; } = RND.Next(1, 6);

        //Method
        public int Roll()
        {
            RollVal = RND.Next(1, 6);
            return RollVal;
        }
    }
}
