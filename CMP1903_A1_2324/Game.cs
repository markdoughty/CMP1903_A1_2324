using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();

        public void rolling()
        {
            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();
            Console.WriteLine("Roll 1 is " + roll1);
            Console.WriteLine("Roll 2 is " + roll2);
            Console.WriteLine("Roll 3 is " + roll3);
            Console.WriteLine("Your total is " + (roll1 + roll2 + roll3) );
            Console.WriteLine("Type exit to leave or press enter to go again");


        }

        
    }
}
