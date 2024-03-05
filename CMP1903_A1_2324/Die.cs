using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        
        private int _DieVal;
        private Random rand = new Random();
        
        public int DieVal
        {
            get { return _DieVal; }
            set { _DieVal = value; }
        }

        //Method

        public int Roll()
        {
            DieVal = rand.Next(1,7);

            // checks to make sure that the current value is between expected range

            return DieVal;
            
        }

    }
}
