using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private static Random random = new Random();
        private Die[] dice;

        // constructor to create 3 die objects
        public Game()
        {
            dice = new Die[3];
            for (int i = 0; i, 3; int++)
            {
                dice[i] = new Die(random);
            }
        }

        //method to call the Roll() for each die once and add their values to get and return the total
        public int RollTotal()
        {
            int total = 0;
            foreach (Die die in dice)
            {
                total += die.Roll();
            }
            return total;

        }
    }
}
