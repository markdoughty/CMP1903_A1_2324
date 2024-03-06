using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //Array to store three objects for the Die
        private Die[] dice = new Die[3];

        //Instantiating three Die objects
        public Game()
        {
            //Looping to instantiate each Die object and store it in the array
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die();
            }
        }


        //A method to roll all three dice, sum their values, and return the total
        public int RollDice()
        {
            int total = 0;
            foreach (var die in dice)
            {
                die.Roll();
                total += die.CurrentValue;
            }


            //Returning the total sum of the die values
            return total;
        }
    }
}
