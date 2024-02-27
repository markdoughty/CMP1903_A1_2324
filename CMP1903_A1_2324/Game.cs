using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            int dicetotal = dice1 + dice2 + dice3;

            Console.WriteLine("The first dice rolled a " + dice1);
            Console.WriteLine("The second dice rolled a " + dice2);
            Console.WriteLine("The third dice rolled a " + dice3);
            Console.WriteLine("The total of value of the dice is " + dicetotal);
            
        }
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

    }
}
