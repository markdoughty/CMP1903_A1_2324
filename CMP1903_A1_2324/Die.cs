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
        public int DiceNum = 0;
        public int DiceNumber
        {
            get {return DiceNum;}
            set {DiceNum = value;}
        }

        public int Roll1()
        {
            Random rolling1 = new Random((int)DateTime.Now.Ticks);
            int diceroll = rolling1.Next(1,7);
            int updatedice = DiceNum + diceroll;
            return updatedice;
        }
        public int Roll2()
        {
            Random rolling2 = new Random((int)DateTime.Now.Ticks);
            int diceroll = rolling2.Next(1, 7);
            int updatedice = DiceNum + diceroll;
            return updatedice;
        }

        public int Roll3()
        {
            Random rolling3 = new Random((int)DateTime.Now.Ticks);
            int diceroll = rolling3.Next(1, 7);
            int updatedice = DiceNum + diceroll;
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
