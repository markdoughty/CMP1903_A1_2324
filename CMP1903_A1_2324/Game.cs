using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Properties

        // Creates 3 Die objects
        private Die dice = new Die();
        private Die dice_2 = new Die(); 
        private Die dice_3 = new Die();

        // Creates a new List
        public List<int> dice_list = new List<int>();

        // Creates an integer that holds the sum of the dices
        private int SumOfDices = 0;

        //Methods

        // An encapsulated method that takes multiple Die objects in its parameters
        private void RollDices(params Die[] dices)
        {
            // A loop that checks each object in the parameters
            foreach (Die dice in dices)
            {
                int result = dice.Roll(); // Rolls each 'Die' object
                Console.WriteLine("Diced Rolled: " + result); // Outputs the dice rolled
                dice_list.Add(result); // Adds rolled dice to list
            }
        }

        // An encapsulated method that gets the dice total
        private int GetDiceTotal()
        {
            // Converts list to array
            int[] dice_array = dice_list.ToArray();

            // A loop that checks how many dice rolled have been added to a list
            for (int i = 0; i < dice_array.Length; i++)
            {
                SumOfDices += dice_array[i];
            }

            return SumOfDices;
        }

        // An encapsulated method that outputs the summary data of the game
        private void GetSummary()
        {
            int[] dice_array = dice_list.ToArray(); // Converts list to array for easier usability

            int lowest = dice_array[0]; // Initialises the lowest number to first element of array
            int highest = dice_array[0]; // Initialises the highest number to first element of array
            int average = SumOfDices / dice_array.Length; // Gets the average number of the dices rolled

            // A loop that performs a search for the lowest and highest number
            for (int i = 0; i < dice_list.ToArray().Length; i++) // Checks each index in the array
            {
                if (dice_array[i] < lowest) // Compares index in the array to the lowest number
                {
                    lowest = dice_array[i]; // Sets the lowest number
                }
                else if (dice_array[i] > highest) // Compares index in the array to the highest number
                {
                    highest = dice_array[i]; // Sets the highest number
                }
            }

            // Prints out a summary of the game
            Console.WriteLine("-------- DICE ROLL GAME : SUMMARY --------");
            Console.WriteLine("Average of the dice rolled (INT): " + average);
            Console.WriteLine("Highest dice rolled: " + highest);
            Console.WriteLine("Lowest dice rolled: " + lowest);
            Console.WriteLine("---------------  THE END   ---------------");

        }
        
        // Encapsulated method, will allow the user to play again in a continuous manner
        private void ContinueGame()
        {
            Console.WriteLine("Play Again? (Type Y to play again / Press any key to end game.)"); // Prompts the user for input
            Game new_game = new Game(); // Creates a new game object

            string user_input = Console.ReadLine(); // Takes input from user

            if (user_input.ToLower() == "y") // Checks if the user has entered the letter Y
            {
                new_game.StartGame(); // If condition is met, a new game will start
            }
            else return; // If any other input is entered, nothing will happen

        }

        // Main method, public, will be used to start the game
        public void StartGame()
        {
            RollDices(dice, dice_2, dice_3);
            Console.WriteLine("Sum of Dice Rolled: " + GetDiceTotal());
            GetSummary();
            ContinueGame();
        }
    }
}
