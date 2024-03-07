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
        private Die die1;
        public int roll1;

        private Die die2;
        public int roll2;

        private Die die3;
        public int roll3;

        public int total;
            

        // Method
        public void RollDie()
        { 
            die1 = new Die(); //Instantiates die objects
            roll1 = die1.Roll(); 

            die2 = new Die();
            roll2 = die2.Roll();

            die3 = new Die();
            roll3 = die3.Roll();

            total = roll1 + roll2 + roll3;
            Console.WriteLine("Total roll = " + total); 
        }
    }
}
