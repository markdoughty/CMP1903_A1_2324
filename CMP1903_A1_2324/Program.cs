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

            //Introduction to the program, tells the user what is going to happen
            Console.WriteLine("This is a dice rolling program. First run will be the normal game. Second will run testing die objects.");

            //Normal run of program
            Game game = new Game();
            game.PlayGame();

            //Testing run of program
            Testing testing = new Testing();
            testing.TestGame();
            
            //Endless run
            while (Choice() == true)
            {
                game.PlayGame();
            }
        }

        // Function used to get user to pick whether or not they want to continue the program
        static bool Choice()
        {
            string option = "";

            //Loops until valid option is picked
            while (true)
            {
                Console.WriteLine("Please type Y or N to choose whether or not to continue the program.\nPress enter to continue...");
                option = Console.ReadLine();

                if (option == "Y")
                    return true;

                if (option == "N")
                    return false;
            }
        }
    }
}
