using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        /*
         * storing the random function as a property as to not instantiate the code multiple times
         * 
         */
        public static Random RandomInstance { get; } = new Random();
        static void Main(string[] args)
        {
            
            /*
             * creating a game object and its methods
             */
            
            var game = new Game();
            //creating 3 new dice integers
            
            /*
             * creating an integer to hold the final result of the calcuation
             */
            int sum;
            /*
             * again is used to hold a sting that will hold the user input
             */

            string again;
            /*
             *Die1, Die2 and Die3 are 3 empty integers that will hold the result of each roll
             */
            int Die1;
            int Die2;
            int Die3;
            /// <summary>
            /// holds all of the main code and creates a game loop
            /// </summary>
            void Main()
            {
                //creating 3 new dice objects and adding them to they're respective dice
                Die1 = game.newDice();
                Console.WriteLine(Die1);
                Die2 = game.newDice();
                Console.WriteLine(Die2);
                Die3 = game.newDice();
                Console.WriteLine(Die3);

                //calling the sumDice function to add all 3 dice together
                sum = game.SumDice(Die1 ,Die2, Die3);


                //outputting the sum of the dice
                Console.WriteLine("the numbers = " + sum);
                //asking the user if they would like to rol the dice again
                Console.WriteLine("would you like to play again (y or n)");
                //taking the user input and storing it inside of the again sring 
                again = Console.ReadLine();
                
                
                //until valid user input
                while (again != "y" || again != "n")
                {
                    //if y then call the main function again
                    if (again == "y")
                    {
                        Main();
                    }
                    //if n then break out of the function
                    else if (again == "n")
                    {
                        break;
                    }
                    //if else it will ask the user for their input again
                    else
                    {
                        Console.WriteLine("would you like to play again (y or n)");
                        again = Console.ReadLine();
                    }
                }

            }
            //calling the main function
            Main();
                


            
            

            
            //applying the testing class to a variable
            var testing = new Testing(game);

            //running the final tests
            testing.RunTest();

           

        }
    }
}
