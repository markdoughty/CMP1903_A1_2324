using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Property

        static Random random = new Random():
        int dieroll;

        //Method
        public int Roll()
        {
            dieroll = random.Next(0,6);
            return dieroll;
        }
    }
}
