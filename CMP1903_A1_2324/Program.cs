using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        /// <summary>
        /// Main method to create a Game object and call its methods.
        /// </summary>
        
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            
            var input = "";
            var gameObj = new Game();
            
            var test = new Testing();
            test.RunTests(); 

            while (input != "exit")
            {
                var (sum, roll1, roll2, roll3) = gameObj.StartGame();

                Console.WriteLine($"First roll: {roll1}\nSecond roll: {roll2}\nThird roll: {roll3}\nSum of dice: {sum}");
                Console.WriteLine("Press enter to continue or submit 'exit' to leave.");
                input = Console.ReadLine();
            }
        }
    }
}
