using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        private Die _die1 = new Die();  //camel case as they are private not public
        private Die _die2 = new Die();
        private Die _die3 = new Die();

        public void rolling()
        {
            int roll1 = _die1.Roll();
            int roll2 = _die2.Roll();
            int roll3 = _die3.Roll();
            Console.WriteLine("Roll 1 is " + roll1);
            Console.WriteLine("Roll 2 is " + roll2);
            Console.WriteLine("Roll 3 is " + roll3);
            Console.WriteLine("Your total is " + (roll1 + roll2 + roll3) );
            Console.WriteLine("Type exit to leave or press enter to go again");


        }

        
    }
}
