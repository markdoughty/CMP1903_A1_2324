using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // This is the property to hold the current value of the dice
        public int FaceValue { get; private set; }

        // This is the random number generator for rolling the dice.
        private Random random;

        // This is the constructor.
        public Die()
        {
            // This code initializes the random number generator.
            random = new Random();
            
            // This Rolls the dice at the start to give it a starting value.
            Roll();
        }

        // This is the method to roll the dice.
        public void Roll()
        {
            // This generates a random number from  1-6 including 1 and 6.
            FaceValue = random.Next(1, 7);
        }
    }
}

