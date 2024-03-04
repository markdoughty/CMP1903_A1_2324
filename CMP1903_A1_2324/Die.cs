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
        int count = 0;

        private Random rand = new Random();
        private int _DieVal;
        public int DieVal
        {
            get { return _DieVal; }
            set { _DieVal = value; }
        }

        //Method


        public int Roll()
        {
            
            // random number from range 1 to 6

            List<int> DieList = new List<int>();

            for (int i = 1; i < 4; i++)
            {
                DieList.Add(rand.Next(1, 7));
            }

            if (count == 0)
            {
                DieVal = DieList[0];
                count = count + 1;
                Console.WriteLine(count);
                return DieList[0];
            }


            if (count == 1)
            {
                DieVal = DieList[1];
                count = count + 1;
                Console.WriteLine(count);
                return DieList[1];
            }


            if (count == 2)
            {
                DieVal = DieList[2];
                count = count + 1;
                Console.WriteLine(count);
                return DieList[2];
            }



            // returning dice number that was stored inside list
            return 0;
            

            
        }

    }
}
