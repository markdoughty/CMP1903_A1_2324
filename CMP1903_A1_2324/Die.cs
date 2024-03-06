using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
    internal class Die
    {
        // Property to hold the current die value
        public int FaceValue { get; private set; }

        // Method to roll the die and return the result
        public int Roll()
        {
            Random random = new Random();
            FaceValue = random.Next(1, 7); // Generates a random number between 1 and 6
            return FaceValue;
        }
    }
}
}
