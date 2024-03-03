using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        Die die;
        Random random = new Random();
        int overallSum = 0;
        int numberOfRolls = 0;

        public Game()
        {
            this.die = new Die();
        }

        /// <summary>
        /// Rolls a number of dice and gets the sum.
        /// </summary>
        /// <param name="rolls">The amount of dice to roll.</param>
        /// <returns>The sum of the rolls.</returns>
        public int Roll(int rolls)
        {
            int sum = 0;
            for (int i = 0; i < rolls; i++)
            {
                sum += die.Roll(random);
            }
            numberOfRolls += rolls;
            overallSum += sum;
            return sum;
        }

        /// <summary>
        /// Returns the average of the dice rolls.
        /// </summary>
        public float Average
        {
            get { return (float)overallSum / numberOfRolls; }
        }

    }
}
