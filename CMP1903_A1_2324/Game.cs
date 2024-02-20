using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        /// <summary>
        /// Game class to create three die objects, roll them, sum and report the total of the three dice rolls.
        /// </summary>
        
        private Die _dice1 = new Die();
        private Die _dice2 = new Die();
        private Die _dice3 = new Die();

        /// <summary>
        /// Method to roll the three dice and return the sum of the rolls.
        /// </summary>
        /// <returns>Sum of the rolls, and each individual rolls</returns>
        public (int sum, int roll1, int roll2, int roll3) StartGame()
        {
            var roll1 = _dice1.Roll();
            var roll2 = _dice2.Roll();
            var roll3 = _dice3.Roll();

            return (roll1+roll2+roll3, roll1, roll2, roll3);
        }
    }
}
