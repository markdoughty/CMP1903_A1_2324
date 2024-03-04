using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public void Start_Test()
        {
            Console.WriteLine("=========== TEST VERSION ===========");
            Test_Game();
            Test_Die();
        }

        // Encapsulated Method
        private void Test_Game()
        {
            // Create new game
            Game game = new Game();
            game.StartGame(); // Call method

            int sum = 0;
            int min_sum = 3;
            int max_sum = 18;

            // A loop that goes through all of the dices rolled in the game
            foreach (int dice in game.dice_list) // Checks each dice rolled, stored in a list
            {

                Debug.Assert(dice <= 6 && dice >= 1, $"The dice rolled ({dice}) from the list of dices ({game.dice_list}) is not between 1 and 6"); // Compares each dice rolled, checking if it is equal or higher than 1, equal or less than 6
                sum = sum + dice;
            }

            // Checks if the total of the dice values are within the allowed limit
            Debug.Assert(sum >= min_sum && sum <= max_sum, "The sum of the dice values are not within the limit. (3 - 18).");
        }

        // Encapsulated Method
        private void Test_Die()
        {
            // Created new Die
            Die dice_test = new Die();
            int rolled_dice = dice_test.Roll(); // Calls the method in Die

            Debug.Assert(rolled_dice <= 6 && rolled_dice >= 1); // Compares output received from Die, ensuring it is less or equal than 6, equal or higher than 1
        }
        //
    }
}
