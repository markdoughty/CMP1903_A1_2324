using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Property
        public int DieValue { get; private set; }  // Holds the die's current value
        
        // Method 
        public int Roll()
        {
            Random random = new Random();

            DieValue = random.Next(1, 7);   // Generate a random number between 1 and 6.

            return DieValue;
        }
    }
}

