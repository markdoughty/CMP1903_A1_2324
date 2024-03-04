using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int _Roll;
        int count1 = 0;





        // Properties
        public int Rolls
        {
                    
            get { return _Roll; }
            set { _Roll = value; }
        }

        //Created the Roll method to randomly roll a die three times
        public  int Roll()
        {

            int randNum = randNum.Next(1, 7);
            
            return randNum;
            
        }

    }
}
