using System;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Asigning a static random object for the generation of the random numbers
        private static readonly Random random = new Random();
        //Using encapsulation to store the current value of the die
        public int CurrentValue { get; private set; }
        //Method for rolling the die and updating the CurrentValue
        public void Roll()
        {
            //Generating a random number between 1 and 6 
            CurrentValue = random.Next(1, 7);
        }
    }
}
