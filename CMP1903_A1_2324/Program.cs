using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times would you like to roll the dice");
            string NumTimes = Console.ReadLine();
            try
            {
                Convert.ToInt16(NumTimes);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: Did not enter a number");
                Console.WriteLine("Defaulted to 1 roll!");
                Console.WriteLine();
                NumTimes = "1";

            }

            Game Game1 = new Game();
            int OverallSum = 0;
            for (int i = 0; i <= Convert.ToInt16(NumTimes) - 1; i++)
            {
                Console.WriteLine("ROLL:" + (i + 1));
                Console.WriteLine("---------");
                Game1.RollDie();
                Console.WriteLine("Die 1 rolled a: " + Game1.GetRoll1());
                Console.WriteLine("Die 2 rolled a: " + Game1.GetRoll2());
                Console.WriteLine("Die 3 rolled a: " + Game1.GetRoll3());
                Console.WriteLine("Total =  " + Game1.GetTotal());
                OverallSum += Game1.GetTotal();
                Console.WriteLine();
            }
            Console.WriteLine("Sum of all dice rolls is: " + OverallSum);
            Console.WriteLine("Num of 3 in a rows: " + Game1.Get3InARowCount());

            Console.WriteLine();
            Testing TestObject = new Testing();
            Console.WriteLine(TestObject.TestGame());
            Console.WriteLine(TestObject.TestDie());

            Console.ReadKey();
        }
    }
}
