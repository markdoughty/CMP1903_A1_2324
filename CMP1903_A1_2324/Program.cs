using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialise the game and output the sum for the user 
            Game game = new Game();
            
            

            //test the game works 
            Testing.Testings();

            //this is so the window will not close after the program finishes
            Console.ReadKey();
        }
    }
}
