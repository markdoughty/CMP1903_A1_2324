using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        
         // The Die class should contain one property to hold the current die value,
         // and one method that rolls the die, returns an integer and takes no parameters.
         

        //Property

        public int diceValue;
        //stores the die value

        static Random rnd = new Random();
        //creates a function for randomised integers



        //Method
        public int Roll()
        {
            int randomNum = rnd.Next(1, 7);
            //creates a random number variable

            return randomNum;
            //returns the random number from where its called
        }

    }
}
