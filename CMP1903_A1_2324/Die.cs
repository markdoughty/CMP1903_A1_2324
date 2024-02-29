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

        // Properties
        public  int Rolls
        {
                    
            get { return _Roll; }
            set { _Roll = value; }
        }

        //Created the Roll method to randomly roll a die three times
        public int Roll(int count = 0)
        {
            List<int> RollList = new List<int>();


            Random rand = new Random();
           
            //Randomly rolling 3 times and saves into a list
            for (int i = 1; i <= 3; i++)
                RollList.Add(rand.Next(1, 7));
            
            Console.WriteLine();
            


            //the rolls get returned 
            return RollList[count];
            
        }
    }
}
