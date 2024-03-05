using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Do you want to roll the die more than once? (Yes/No):");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "no" || userInput == "n")
            {
                Die die = new Die();
                int rollValue = die.Roll();
                Console.WriteLine("You Rolled A: " + rollValue);
            }
            else if (userInput == "yes" || userInput == "y")
            {
                DiceRoller DiceRoller = new DiceRoller();
                DiceRoller.RollContinuous();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'Yes' or 'No'.");
                
            }

            Game game = new Game();

            Console.WriteLine($"Total Sum is: {game.Sum}");

            

            Testing testing = new Testing();
            Testing.RunTests(game);





            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        }
    }
    


}
