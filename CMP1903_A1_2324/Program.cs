using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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
            
           

            Game game = new Game();
            int DieTotal = game.DieSum();
            Console.WriteLine("Die Total: " + DieTotal);
            

            Testing Test = new Testing();
            Test.DieTestResult();
            Test.GameTestResult();

            Console.WriteLine("Press any key to end program...");
            Console.ReadKey();



        }
    }
}
