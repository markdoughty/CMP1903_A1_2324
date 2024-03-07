using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Game
    {
        //calling the Die class
        
        /// <summary>
        /// creates a new dice object and calls the roll function to assign it a random number
        /// </summary>
        /// <returns>the new dice value</returns>
        public int newDice()
        {
            var Dice = new Die();
            //rolling the dice
            int Die = Dice.Roll();

            //returns the final number
            return Die; 
        }
        /// <summary>
        /// adds all 3 of the dice together once called
        /// </summary>
        /// <param name="Die1">1st dice value</param>
        /// <param name="Die2">2nd dice value</param>
        /// <param name="Die3">3rd dice value</param>
        /// <returns>the sum of all 3 dice</returns>
        public int SumDice(int Die1, int Die2, int Die3)
        {
            //adds all of the integers together
            int sum = Die1 + Die2 + Die3;
            //returns the final result
            return sum;

        }
    }
}
