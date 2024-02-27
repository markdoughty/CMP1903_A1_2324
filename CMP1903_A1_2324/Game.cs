using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public static void Main(string[] args)
        {
            Die Die1 = new Die();
            Die Die2 = new Die();
            Die Die3 = new Die();

           

            
            List<int> RollList = new List<int>();
            // RollList.Add(Die1.Roll());
            // RollList.Add(Die1.Roll());
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(Die1.Roll(i));
                RollList.Add(Die1.Roll(i));

            }
            int Roll1 = RollList[0];
            int Roll2 = RollList[1];
            int Roll3 = RollList[2];
            

            // int roll1 = Die1.Roll();
            // int roll2 = Die2.Roll();
            // int roll3 = Die3.Roll();
            //     
            // Console.WriteLine("Die 1: " + roll1);
            // Console.WriteLine("Die 2: " + roll2);
            // Console.WriteLine("Die 3: " + roll3);
            //
            int rolltotal = Roll1 + Roll2 + Roll3;
                

            Console.WriteLine(rolltotal);
            

        }
    }
}
