using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // allows for arrays []
        private Die[] dice;
       
        // forms a 3 dice array using the Die class
        public Game()
        {
            // for statment allows the Dice total to only add up 3 die
            dice = new Die[3];
            for (int i = 0; i < 3; i++)
            {
                dice[i] = new Die();
            }

        }
        /* this function adds up the total of the 3 die */
        public int DiceTotal()
        {
            int Total = 0;
            foreach (Die die in dice)
            {
                Total += die.Roll();
            }
            return Total;
        }
    }
}
