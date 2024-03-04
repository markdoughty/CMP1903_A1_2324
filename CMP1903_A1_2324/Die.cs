using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private int dieval;

        public int Dieval
        {
            get { return dieval; }
            set { dieval = value; }
        }
        public int Roll()
        {
            Random random = new Random();
            dieval = random.Next(1, 7);
            Console.WriteLine(dieval);
            return dieval;
        }
    }
}
