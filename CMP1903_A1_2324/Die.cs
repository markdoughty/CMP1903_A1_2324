using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        static Random random = new Random();
        int dieroll;

        public int Roll()
        {
            dieroll = random.Next(1,7); //1-7 as it is not inclusive
            return dieroll;
        }
    }
}
