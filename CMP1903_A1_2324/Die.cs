using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903_A1_2324;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        public int die_value; //creates an integer veriable that we asign the roll to



        //Method
        public int roll()        //creates a function and assigns the result to the variable I declared earlier
        {
            die_value = rnd.next(1,7); //creates a random integer between 1 and 6 and assigns it to a variable

            return die_value;
        }

        


    }
}
