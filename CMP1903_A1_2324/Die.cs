using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    // Die Class
    public class Die
    {
        // gets random
        private Random random;

        // creates current value variable
        public int CurrentValue; 

        public Die(Random random)
        {
            // assures each die is random and assigns current value to 0
            this.random = random;
            CurrentValue = 0;
        }

        public int Roll()
        {
            // assigns current value to a random number between 1 and 6
            CurrentValue = random.Next(1, 7); 
            return CurrentValue;
        }
    }
}
