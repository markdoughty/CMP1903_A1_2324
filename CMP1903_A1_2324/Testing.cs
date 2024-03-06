using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    static void Main(string[] args)
    {
        Console.WriteLine("The dice roll game"); //displays to the user the game has started

        Console.Write("Enter the number of dice to roll: "); //Allows the user to enter number of dice to be rolled
        int num_Dice = int.Parse(Console.ReadLine()); //Converts string from the user into an integer value

        Game game = new Game(num_Dice); //Displays the new game based on the num of dice declared

        Console.WriteLine("The dice roll game"); //repeats the game if the user rerolls

        bool reroll = true; //Initially sets the reroll as true 

         while (reroll)
        {
            Console.WriteLine("\nDice set"); 
            game.Program();

            string rerollInput; //allows the user to input the reroll choice

            do
            {
                Console.Write("Do you want to reroll? (Y/N): ");
                rerollInput = Console.ReadLine().ToLower(); 
            } while (rerollInput != "Y" && rerollInput != "N"); //if user inputs something other than "Y" or "N" it loops back

            reroll = rerollInput == "Y"; //Rolls if Y

            
            Debug.Assert(total >= numberOfDice && total <= numberOfDice * 6,
                $"Total is greater or less than the possible combination of totals ({numberOfDice} to {numberOfDice * 6})."); //Checks to make sure that the value cannot be creater than 18 or less that 3 as its not in the possible combination of die roll totals
        }
    }
}
