using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {

        // Properties
        private Die _die1;
        public int roll1;

        private Die _die2;
        public int roll2;

        private Die _die3;
        public int roll3;

        public int total;
            

        // Method
        public void RollDie()
        { 
            _die1 = new Die(); //Instantiates die objects
            roll1 = _die1.Roll(); 

            _die2 = new Die();
            roll2 = _die2.Roll();

            _die3 = new Die();
            roll3 = _die3.Roll();

            total = roll1 + roll2 + roll3;
            Console.WriteLine("Total roll = " + total); 
        }
    }
}
