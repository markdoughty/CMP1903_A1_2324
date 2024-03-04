using System;
using System.Collections.Generic;
using System.Linq;
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
        private int _Count;

        public int Count
        {
            get { return Count; }
            set { Count = value; }
        }

        //Method
        private static void Roll()
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1, 7)); //returns random integers < 10

        }


    }
}
