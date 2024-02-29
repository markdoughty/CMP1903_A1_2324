using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Game
    {
        public int myMethod()
        {
            
            //Created three die objects 
            Die Die1 = new Die();
            Die Die2 = new Die();
            Die Die3 = new Die();

            List<int> RollList = new List<int>();



            // Roll all three and saved it in roll 1, 2, 3 
            int Roll1 = Die1.Roll(0);
            int Roll2 = Die2.Roll(1);
            int Roll3 = Die3.Roll(2);

            //Output what each die roll was
            Console.WriteLine("Die 1: " + Roll1);
            Console.WriteLine("Die 2: " + Roll2);
            Console.WriteLine("Die 3: " + Roll3);

            //Calculating the total
            int rolltotal = Roll1 + Roll2 + Roll3;

            //Displaying the total
            Console.WriteLine(rolltotal);

            return rolltotal;
        }
    }
}
