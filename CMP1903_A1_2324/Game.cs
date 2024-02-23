using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

        public void rollDice(int rollAmount)
        {
            int i = 1;
            int sum = 0;
            List<int> list = new List<int>();

            while (i <= rollAmount)
            {
                Die die = new Die();
                int roll = die.dieRoll();
                Console.WriteLine($"Roll {i}: {roll}");
                list.Add(roll);
                i++;
                System.Threading.Thread.Sleep(1);
            }

            foreach (int item in list) { sum += item; }
            Console.WriteLine($"\nSum: {sum}");
        }



    }
}

