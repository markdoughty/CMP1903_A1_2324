using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int current_Value;
        
        /// <summary>
        /// exposes _current value whle not allowing it to be changed by anything 
        /// other than the class or its children
        /// </summary>
        public int CurrentValue
        {
            get => current_Value;

            set => current_Value = value;
        }



        /// <summary>
        /// picks a random number between 1 and 6, sets that to the current value and returns the result
        /// </summary>
        /// <returns>the random number</returns>
        public int Roll()
        {
            //rolling a number between 1 and 6
            int newRoll = Program.RandomInstance.Next(1, 7);
            //setting the roll to the current value
            current_Value = newRoll;
            //returning the roll
            return newRoll;
        }

    }
}

