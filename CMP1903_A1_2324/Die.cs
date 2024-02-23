using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property





        //Method
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice1 = Random.Next(1, 7);
            int dice2 = Random.Next(1, 7);
            int dice3 = Random.Next(1, 7);
            Console.WriteLine(dice1);
            Console.WriteLine(dice2);
            Console.WriteLine(dice3);
            Console.Readkey();
        }

    }
}
