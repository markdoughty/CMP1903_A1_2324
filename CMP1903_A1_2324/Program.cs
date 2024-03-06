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
            
           

            Game game = new Game(); // Creates an instance of the Game class 
            int DieTotal = game.DieSum(); // Runs the DieSum Method located the Game class and saves variable to DieTotal
            Console.WriteLine("Die Total: " + DieTotal);
            

            Testing Test = new Testing(); // Creates an instance of the Testing class
            Test.DieTestResult(); // Runs the DieTestResult method in Testing class
            Test.GameTestResult();  // Runs the GameTestReult method in Testing class

            Console.WriteLine("Press any key to end program...");
            Console.ReadKey(); // ensures the program doesn't quit out before the user can see DieTotal result 



        }
    }
}
