using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        public int Roll()
        {
            var random = new Random();
            var num = random.Next(1, 7);
            return num;
        }
    }
}
