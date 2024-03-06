using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Die DieOne;
        private Die DieTwo;
        private Die DieThree;

        // Initialize the three Die objects
        public Game()
        {
            DieOne = new Die();
            DieTwo = new Die();
            DieThree = new Die();
        }
        public int Play()                               // Assigns values to the variables and rolls each individual die
        {
            int RollOne = DieOne.Roll();
            int RollTwo = DieTwo.Roll();
            int RollThree = DieThree.Roll();

            int total = RollOne + RollTwo + RollThree;  // Calculate the total of the three rolls

            Console.WriteLine("The rolls were " + RollOne + ", " + RollTwo + ", and " + RollThree + ". Total: " + total); //Reports total

            return total;
        }
    }
}
       

 
