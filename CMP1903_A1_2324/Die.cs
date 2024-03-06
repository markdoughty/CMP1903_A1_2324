using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        int RollValue;
        int Total;

        public int Roll(Random _rand)
        { 
            RollValue = int _rand.Next(1, 7, 1);
            return RollValue;
            Total = int RollValue + int Total;
            return Total
        }
        //simulates a dice roll
        //produces a random value between 1 and 6
        //returns the value of the dice
        //dice value is added the round total
        //returns the value of the total counter

        
    }
}
