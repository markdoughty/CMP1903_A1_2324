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

        public int Dieval // creates a property called dieval that saves the value of a dice roll
        {
            get { return dieval; }
            set { dieval = value; }
        }
        public int Roll()// roll method, chooses random number between 1 and 6 then returns it
        {
            Random random = new Random();// creates a object called random that is thern used to generate a random number between 1 - 6
            dieval = random.Next(1, 7);
            Console.WriteLine(dieval);
            return dieval;// returns an integer from the method
        }
    }
}
