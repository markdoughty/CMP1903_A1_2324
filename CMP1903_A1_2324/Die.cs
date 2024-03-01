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
            Random rolling1 = new Random();
            int diceroll1 = rolling1.Next(1,7);
            int updatedice1 = DiceNum + diceroll1;
            return updatedice1;
        }
        public int Roll2()
        {
            Random rolling2 = new Random();
            int diceroll2 = rolling2.Next(1, 7);
            int updatedice2 = DiceNum + diceroll2;
            return updatedice2;
        }
        public int Roll3()
        {
            Random rolling3 = new Random();
            int diceroll3 = rolling3.Next(1, 7);
            int updatedice3 = DiceNum + diceroll3;
            return updatedice3;
        }
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property


        //Method


    }
}
