using System;
using System.Collections.Generic;
using System.IO;
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
            //Initialise variable to be used in loop
            bool valid = false;

            //Loop to error handle so that if an invalid input is entered the user can try again without the program closing.
            while (valid == false)
            {
                //Ask the user if they want to test the dice or play the game, store their answer in a string variable and ensure its uppercase.
                Console.WriteLine("Do you want to run the test? Y/N");
                string Confirm = Console.ReadLine();
                Confirm = Confirm.ToUpper();
                //Exception handling, try to carry out the if statements to check if the user inputted a valid character and then throw an error if the input is invalid.
                try
                {
                    //If the users input is y or Y then carry out the test
                    if (Confirm == "Y")
                    {
                        valid = true;
                        //Constructor to test the dice are correct values and result
                        Testing test = new Testing();
                        test.Test();
                    }
                    //If the users input is n or N then play the game
                    else if (Confirm == "N")
                    {
                        //Constructor to create a new Game object and display it in the console.
                        valid = true;
                        Game game = new Game();
                        Console.WriteLine($"Sum of Dice:  {game.Build()}");
                    }
                    //If neither statement is carried out then throw an error as it is an invalid input
                    else
                    {
                        throw new Exception();
                    }
                }
                //Catch the exception we have previously thrown as a result of an invalid input and display a message alerting the user of the mistake.
                catch (Exception)
                {
                    Console.WriteLine("Invalid character or symbol, try again.");
                }
            }
            //Prevents the application from ending abruptly.
            Console.ReadKey();
        }
    }
}
