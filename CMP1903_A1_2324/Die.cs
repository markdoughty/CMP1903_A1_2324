using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
        private int _DieValue;


       

        public int DieValue
        {
            get { return _DieValue; }
            set
            {
                Random value = new Random();
                _DieValue = value.Next(1, 7); } // Creates a random value between 1 and 6
            } 
        }

       

        //Method
        


         
    }
}
