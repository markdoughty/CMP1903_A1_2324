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

          
            // testing object 
            Testing test = new Testing();
            test.runningtest();
            Console.WriteLine("Successful Test");       // informs the user the test was completed 
            Game game = new Game();

           Console.ReadLine();         // this reads the code so it can run 
        }
    }
}
