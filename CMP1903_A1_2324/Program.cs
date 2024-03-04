using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DieGame_Assessment_1
{
    // Program class
    class Program
    {
        // Main used to run program (uses as entry point)
        static void Main(string[] args)
        {
            // Calls the Test method to start the program
            Testing.Test();
            // Stops the console from closing until a user input
            Console.ReadKey();
        }
    }
}
