using System;
using System.Collections.Generic;
using System.Linq;
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


        public int DieSum() // create public method called DieSum
        {
            Die die = new Die(); // Create instance of the Die class
            int DieRoll = die.Roll(); // use method Roll() found in the Die class and save result to DieRoll


            Die die1 = new Die(); // same as previous 2 lines but creates new instance and variable 
            int DieRoll1 = die.Roll();

            
            Die die2 = new Die();
            int DieRoll2 = die.Roll();
     

            int DieTotal = DieRoll + DieRoll1 + DieRoll2; // combines the three DieRoll variables together and saves result to DieTotal
            

            return DieTotal; // returns the Die total when method is called
        }
    }
}
