using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Die
    {
        private Random randomGenerator;

        public Die()
        {
            randomGenerator = new Random();
        }

        public int RollDie()
        {
            return randomGenerator.Next(1, 7);
        }
    }
}
