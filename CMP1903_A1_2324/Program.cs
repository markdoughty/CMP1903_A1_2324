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
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Do you want to run the test? Y/N");
                string Confirm = Console.ReadLine();
                Confirm = Confirm.ToUpper();
                try
                {
                    if (Confirm == "Y")
                    {
                        valid = true;
                        //Constructor to test the dice are correct values and result
                        Testing test = new Testing();
                        test.Test();
                    }
                    else if (Confirm == "N")
                    {
                        //Constructor to create a new Game object and display it in the console.
                        valid = true;
                        Game game = new Game();
                        Console.WriteLine($"Sum of Dice:  {game.Build()}");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid character or symbol, try again.");
                }
            }
            Console.ReadKey();
        }
    }
}
