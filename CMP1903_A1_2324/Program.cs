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

          //bool playing = false; 
            // testing object 
            Testing test = new Testing();
            test.runningtest();
            Console.WriteLine("Successful Test");       // informs the user the test was completed 
            Game game = new Game();
            


            // making a loop to reroll the dice 
            //while (playing != false)        // while the game isn't over 
            //{
            //    Console.WriteLine("Would you like to roll again? : ");
            //    string answer = Console.ReadLine();

            //    if (answer == "yes")
            //    {
            //        game.GameRolls();       // re-rolls the dice 
            //        playing = true;
            //    }

            //    else if (answer == "Yes")
            //    {
            //        game.GameRolls();       // re-rolls the dice 
            //        playing = true;
            //    }

            //    else if (answer == "YES")
            //    {
            //        game.GameRolls();       // re-rolls the dice 
            //        playing = true;
            //    }

            //    else if (answer == "y")
            //    {
            //        game.GameRolls();       // re-rolls the dice 
            //        playing = true;
            //    }

            //    else if (answer == "Y")
            //    {
            //        game.GameRolls();       // re-rolls the dice 
            //        playing = true;
            //    }

            //    else if (answer == "no")
            //    {
            //        playing = false;        // will exit the loop 
            //    }

            //    else if (answer == "No")
            //    {
            //        playing = false;        // will exit the loop 
            //    }

            //    else if (answer == "NO")
            //    {
            //        playing = false;        // will exit the loop 
            //    }

            //    else if (answer == "N")
            //    {
            //        playing = false;        // will exit the loop 
            //    }

            //    else if (answer == "n")
            //    {
            //        playing = false;        // will exit the loop 
            //    }

            //    else
            //    {
            //        Console.WriteLine("Invalid input ");
            //        playing = true;         // this will allow the player to try again 
            //    }


                
            //}

           Console.ReadLine();         // this reads the code so it can run 
        }
    }
}
