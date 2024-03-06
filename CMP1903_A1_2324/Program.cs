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
            string NumTimes = Console.ReadLine(); //Gets the user to input the number of times to roll the dice
            try
            {
                Convert.ToInt16(NumTimes);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("ERROR: Did not enter a number");
                Console.WriteLine("Defaulted to 1 roll!"); //If the user does not enter a valid integer, an error message will display, and the number of rolls will default to 1
                Console.WriteLine();
                NumTimes = "1";

            }

            Game Game1 = new Game();
            int OverallSum = 0;
            for (int i = 0; i <= Convert.ToInt16(NumTimes) - 1; i++) //Will roll for the number of times inputted by user
            {
                Console.WriteLine("ROLL:" + (i + 1)); //Displays roll count
                Console.WriteLine("---------");
                Game1.RollDie(); //Will roll 3 dice
                Console.WriteLine("Die 1 rolled a: " + Game1.GetRoll1());
                Console.WriteLine("Die 2 rolled a: " + Game1.GetRoll2());
                Console.WriteLine("Die 3 rolled a: " + Game1.GetRoll3()); //Displays all 3 rolls
                Console.WriteLine("Total =  " + Game1.GetTotal()); //Displays total
                OverallSum += Game1.GetTotal(); //Overall sum will update
                Console.WriteLine();
            }
            Console.WriteLine("Sum of all dice rolls is: " + OverallSum); //Displays total of all rolls
            Console.WriteLine("Num of 3 in a rows: " + Game1.Get3InARowCount()); //Displays total number of 3 in a rows

            Console.WriteLine();
            Testing TestObject = new Testing(); //Instantiates a new testing object
            Console.WriteLine(TestObject.TestGame()); //Tests the game for any errors
            Console.WriteLine(TestObject.TestDie()); //Tests the die for any errors

            Console.ReadKey();
        }
    }
}
