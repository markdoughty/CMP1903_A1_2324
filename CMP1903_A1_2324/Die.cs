using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Die
    {
        private int currentValue = 0; //Property to hold the current value of the dice

        public int Roll() //Method to roll dice with no parameters and returns the current value of the dice
        {
            Random random = new Random(); //Random object to generate random numbers
            currentValue = random.Next(1, 7); //Edit values for Testing in testing module. Choooses random number between 1 and 6
            return currentValue; //Returns the current value of the dice
        }
    }
}
