using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        
        private readonly Random _randomValue;  //creates a object
        public Die()
        {
            _randomValue = new Random(); //sets to random
        }
        public int Roll()
        {  
            return _randomValue.Next(1,7); // creates a random number between 1 and 7
        }  
        
    }
}
