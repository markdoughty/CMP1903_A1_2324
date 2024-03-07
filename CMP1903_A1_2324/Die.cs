using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private Random random;
        public int Facevalue { get; private set; }

        // constructor to initialize a die object 
        public Die(Random random)
        {
            this.random = random;
        }
        //Roll the die and set and return the face value which is a random number between 1and 6
        public int Roll()
        {
            Facevalue = random.Next(1, 7);
            return Facevalue;
        }
    }
}
