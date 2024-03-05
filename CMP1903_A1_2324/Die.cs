using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903_A1_2324;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private static Random dice = null;      //having this as static means every dice roll will be unique 
        private int _CurrentDieVal;
        public int CurrentDieVal
        {
            get {return _CurrentDieVal;}        //get method
            set {_CurrentDieVal = value;}       //set method
        }

        //Method
        public int RollDie()
        {
            if (dice == null)            //null because for every dice initialisation, dice does not contain a number
                dice = new Random();     // create a new random called dice
            CurrentDieVal = dice.Next(1, 7);    //generate random number between 1 and 6 and assign this value CurrentDieVal
            return CurrentDieVal;    //return the randomly generated value
        }

    }
}
