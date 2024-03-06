using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        public int DieValue { get; set; }

        public static Random random = new Random();
        
        public  Die()
        {
 
        }

        public int Roll()
        {
            DieValue = random.Next(1,6);
            return DieValue;
           
        }
        
    }
}
