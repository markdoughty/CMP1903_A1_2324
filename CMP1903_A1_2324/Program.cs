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
           
            Game g = new Game(); //creates an object of the game class 

            bool show = true; //creates boolean value for if the program should display the value of each die to user
            int total = 0;
            try //tries to run the following code
            {
                total = g.game(show); //runs the game method in the Game class, then stores the return integer in the variable 'total'
            }
            catch (Exception e) //catches a thrown exception if one occurs
            {
                Console.WriteLine(e.Message); //displays error message thrown from the other class
            }
            Console.WriteLine($"Sum of three dice = {total}"); //displays sum of all 3 dice to user

            Testing test = new Testing(); //creates an object of the Testing class
            test.Game_Test(); //runs method in the Testing class, testing the Game class
            test.Die_Test(); //runs method in the Testing class, testing the Die class
        }
    }
}
