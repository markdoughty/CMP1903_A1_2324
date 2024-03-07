using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            //Methods
            Game gameobj1 = new Game();
            int obj = gameobj1.DiceRoll();
            Testing testingobj1 = new Testing();
            testingobj1.Test();
            Console.ReadLine();
        }
    }
}
