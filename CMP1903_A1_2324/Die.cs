using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        //creates an int variable called DieValue
        public int DieValue = 0;

        //creates a method within the Die class that contains the actions for rolling the die
        public int Roll()
        {
            //creates new instance of random class
            Random rnd = new Random();
            //generates a random int between 1-6 and assigns it to ReturnValue, which it returns at the end of the function
            int ReturnValue = rnd.Next(1, 7);
            return ReturnValue;
        }
    }
}
