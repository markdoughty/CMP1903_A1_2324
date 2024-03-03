using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        int currentValue;

        /// <summary>
        /// Rolls a die.
        /// </summary>
        /// <param name="rand">The random variable to use.</param>
        /// <returns>A dice roll between 1 and 6.</returns>
        public int Roll(Random rand)
        {
            currentValue = rand.Next(1, 7);
            return currentValue;
        }


    }
}
