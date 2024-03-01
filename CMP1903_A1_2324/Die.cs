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

        // current index value of DieNumList
        private int _DieVal;
        public int DieVal
        {
            get { return _DieVal; }
            set { _DieVal = value; }

        }

        //Method

        public int RollDie()
        {
            // new list created to store dice roll values
            List<int> DieNumList = new List<int>();

            // random number from range 1 to 6
            Random rand = new Random();
            DieNumList.Add(rand.Next(1,7));

            // debugging - checking length of list each time
/*            Int32 length = DieNumList.Count;
            Console.WriteLine(length);*/

            // returning dice number that was stored inside list
            return DieNumList[DieVal];
            

            
        }

    }
}
