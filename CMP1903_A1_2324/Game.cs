using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        private Die _die1 = new Die();

        private Die _die2 = new Die();

        private Die _die3 = new Die();


        public void gameRoll()
        {
            int roll1 = _die1.Roll();

            int roll2 = _die2.Roll();

            int roll3 = _die3.Roll();

            Console.WriteLine($"roll 1 = {roll1}\nroll 2 = {roll2}\nroll 3 = {roll3}\nsum = {roll1 + roll2 + roll3}");
        }
 
    }
}
