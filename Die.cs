using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private static Random random = new Random();
        public int die_Value = null; /// Stores the current die value
        public int die_Roll(); /// Die roll method
        {
            die_Value = random.Next(1,7); /// Assigns a random integer between 1 and 6
            return die_Value /// Returns the new die value
        }
    }
}
