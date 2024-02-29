using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
        private Random rand;
        private int _Value;

 
        public Die()
        {
            rand = new Random();
        }

        //Method
        public int roll()
        {
            _Value = rand.Next(1, 7);
            Console.WriteLine("Rolling...");
            Console.WriteLine($"rolled a {_Value}");
            return _Value;
        }


    }
}
