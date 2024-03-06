using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        private int _DieValue;
        private Random random;

        //Property

        public int DieValue
        {
            get { return _DieValue; }
            set { _DieValue = value; }

        }


        //Method
        public int Roll()
        {
            Thread.Sleep(450);
            _DieValue = random.Next(1, 7);
            return _DieValue;
            //return random.Next(1, 7);
        }
        public Die()
        {
            random = new Random();

            //Roll();

        }




    }
}
