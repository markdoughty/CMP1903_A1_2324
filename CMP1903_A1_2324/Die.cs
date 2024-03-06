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
        
        
        public int CurrentValue
        {
            get => current_Value;

            set => current_Value = value;
        }


        // setting random function
        Random rnd = new Random();

        //declaring new function roll()
        public int Roll()
        {
            //rolling a number between 1 and 6
            int newRoll = rnd.Next(1, 7);


            //setting the roll to the current value
            current_Value = newRoll;
            //returning the roll
            return newRoll;
        }

    }
}

