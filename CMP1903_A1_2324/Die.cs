using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        public int DieValue = 0;

        public int Roll()
        {
            Random rnd = new Random();
            int ReturnValue = rnd.Next(1, 7);
            return ReturnValue;
        }
    }
}
