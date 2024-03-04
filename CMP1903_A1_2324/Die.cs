using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Die
    {
        //the values i will use 
        private int heldval;
        private Random roll = new Random();

        public int diceroll()
        {
            //rolls the dice 
            heldval = roll.Next(1, 7);
            return heldval;
        }


        public int fetchvalue()
        {
            //fetches the held value when it is needed 
            
            return heldval;
        }





        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property



        //Method



    }

}