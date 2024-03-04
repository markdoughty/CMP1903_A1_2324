using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /// <summary>
        /// Checks if the roll is between 1-6. Changes Green or Red according to if the response is T/F.
        /// </summary>
        /// <param name="roll"></param>
        /// <returns> Writes in the console if the role is legal, else returns true/false incase you want to do something with this in the future. as no errors are raised. </returns>
        public bool Assert(int roll)
        {
            if (roll >= 1 && roll <= 6)
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Roll is Legal."); Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Roll isn't Legal."); Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
        /// <summary>
        /// Checks if the sum is between 3-18 (1+1+1 or 6+6+6) (min/max). Changes Green or Red according to if the response is T/F.
        /// </summary>
        /// <param name="sum"></param> Sum is the total number after all 3 Dice rolls is added up. 
        /// <returns> True or False </returns>
        public bool AssertSum(int sum)
        {
            if (sum >= 3 && sum <= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Sum is Legal. \n"); Console.ForegroundColor = ConsoleColor.White;
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Sum isn't Legal. \n"); Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
    }
}
