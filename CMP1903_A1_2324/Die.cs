using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        

        //Property
        private int _value;

        //Method
        public int Roll()
        {
            Random rnd = new Random(); //Creates an object from class Random
            _value = rnd.Next(1, 7); //Die value will be a random number between 1 and 6 inclusive
            return _value; 
        }

    }
}
