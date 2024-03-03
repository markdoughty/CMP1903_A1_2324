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
            
             // Create a Game object and call its methods.
             // Create a Testing object to verify the output and operation of the other classes.
             


            Game gameObject = new Game();
            //creates an object from the class "Game"

            Testing testObject = new Testing();
            //creates an object from the class "Testing"

            gameObject.DieCreation();


            Console.WriteLine("\nTest:");
            testObject.test();
            //runs the method within the object created

            Console.ReadKey();
            //Stops program from shutting instantly
        }
    }
}
