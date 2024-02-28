using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        public int DiceValue
        {
            get {return DiceValue;}
            set {DiceValue = value;}
        }
        public int Roll()
        {
            Random rolling = new Random();
            int diceroll = rolling.Next(1, 7);
            int updatedice = DiceValue + diceroll;
            return updatedice;
        }
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        //Method


    }
}
