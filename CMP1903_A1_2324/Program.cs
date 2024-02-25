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


            //create instance of testing class
            Testing test = new Testing();
            //run test method to test teh game and dice classes
            test.testrun();
            //once testing has completed tell the user this is the case
            Console.WriteLine("test passed");
            //allow the program to access the game instantiated in test so that a running total can be used
            Game game = test.game;
            //establish a loop variable
            bool loop = true;
            //loop until the user no longer wants to roll dice
            while (loop != false)
            {
                //ask the user if they want to roll another die
                Console.WriteLine("roll another die y or n");
                //read the users answer
                string reroll = Console.ReadLine();
                // if they say yes
                if (reroll == "y")
                {
                    //roll another die
                    game.roll1();
                    //maintain the loop
                    loop = true;
                }
                //if they say no
                else if (reroll == "n")
                {
                    //do nothing and exit the loop
                    loop = false;
                }
                //for any other input
                else
                {
                    //inform the user of the error
                    Console.WriteLine("please enter a valid option y or n");
                    //keep the loop going to allow a retry
                    loop = true;
                }
            } 
        }
    }
}
