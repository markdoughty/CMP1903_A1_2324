using ClassTest;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903_A1_2324;




/*
 * Create a Game object and call its methods.
 * Create a Testing object to verify the output and operation of the other classes.
 * Make a menu to help users choose to go into game + contineue rolls / Testing section 
 * 
 */

static void Menu(int UserChoice = 0)
{
    Game game = new Game(); //creates game class
    Testing testing = new Testing();



    while (true)
    {
        try
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("Welcome: \nChoice based on corresponding number. \n1- Play Game: \n2- Test Game:\n3- Exit: ");
            Console.WriteLine("--------------------");

            UserChoice = Convert.ToInt32(Console.ReadLine());
            if (UserChoice >= 1 && UserChoice <= 3)
            {
                break;
            }

            else
            {
                Console.WriteLine($"Input ({UserChoice}) out of range!!!!");
                continue;
            }

        }

        catch
        {
            Console.WriteLine("Invalid input!!!!");
        }

    }


    if (UserChoice == 1)
    {

        Console.WriteLine($"Round: {game.Round}");
        game.GameRoll();
        Console.WriteLine($"Combined Total :{game.DieSum} \n");

        while (true)
        {


            try
            {
                Console.WriteLine("Would you like to roll again? (1 = continue 2 = exit)");
                UserChoice = Convert.ToInt32(Console.ReadLine());
                if (UserChoice == 1)
                {
                    game.Round++;
                    Console.WriteLine($"\nRound: {game.Round}");
                    game.GameRoll();
                    Console.WriteLine($"Combined Total :{game.DieSum} \n--------------------");

                    continue;
                }
                else if (UserChoice == 2)
                {
                    break;
                }

                else
                {
                    Console.WriteLine($"Input ({UserChoice}) out of range!!!!");
                    continue;
                }

            }

            catch
            {
                Console.WriteLine("Invalid input!!!!\n");
            }

        }


    }
    else if (UserChoice == 2)
    {
        Console.WriteLine("--------------------\nTESTING");
        testing.TestDieClass();
        testing.TestGameClass();
        Console.WriteLine("End of Testing");
        Menu();
    }

    else if (UserChoice == 3)
    {
        Environment.Exit(0);
    }

}


Menu();
