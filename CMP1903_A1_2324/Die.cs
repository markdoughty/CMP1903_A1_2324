using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        Random rnd = new Random(); // create instance of the random class
        

        //Method
        public int Roll() // Roll() method created
        { 
            int DieRoll = rnd.Next(1, 7); // Random number between 1,6 created and stored in DieRoll variable
            Thread.Sleep(250); // makes the program wait 250 milliseconds (done to stop repation of rolled ints)
            return DieRoll; // returns the DieRoll value
        }

    }
}
