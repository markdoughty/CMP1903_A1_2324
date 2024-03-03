using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


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

            Game rn = new Game(); // Starts a new game and retrives the total.
            int total = (rn.Total());

            Console.WriteLine($"The total of all three die are: {total}"); // Outputs the total of all 3 die to the user.
            Console.ReadKey();
        }
    }
}
