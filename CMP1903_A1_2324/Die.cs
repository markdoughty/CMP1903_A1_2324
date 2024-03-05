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
        int _rollValue;
        int _total;

        public int Roll(Random _rand)
        { 
            _rollValue = int _rand.Next(1, 7, 1);
            return _rollValue;
            _total = int _rollValue + int _total;
            return _total
        }
        //simulates a dice roll
        //produces a random value between 1 and 6
        //returns the value of the dice
        //dice value is added the round total
        //returns the value of the total counter

        
    }
}
