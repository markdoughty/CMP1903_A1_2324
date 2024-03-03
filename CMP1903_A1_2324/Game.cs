using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

        //Methods
        private int _Total;

        public int Total()
        {
            Die rl = new Die();
            int roll1 = (rl.DieRoll()); // 1st random number between 1 and 6.
            int roll2 = (rl.DieRoll()); // 2nd random number between 1 and 6.
            int roll3 = (rl.DieRoll()); // 3rd random number between 1 and 6.
            
            int total = (roll1 + roll2 + roll3); // Adds the 3 dice rolls together.
           
            return total;
        }
    }
}
