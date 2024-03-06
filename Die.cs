using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * *******  Instructions ********
 * The Die class should contain one property to hold the current die value,
 * and one method that rolls the die, returns and integer and takes no parameters.
 */


namespace CMP1903_A1_2324
{
    internal class Die
    {
        private Random random;
        public int CurrentValue { get; private set; }  //Property

        public Die()
        {
            random = new Random();
            Roll();

        }
        
        public int Roll() //Method
        {
            CurrentValue = random.Next(1, 7);
            return CurrentValue;
        }

    }
}
