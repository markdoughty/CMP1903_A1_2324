using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
     class Testing
    {
        Game game = new Game(); //Instntiates the game class (creates an object of the game class)
        public void TestRollDices() //Method to test the RollDices method
        {
            game.RollDices(); //Calls the RollDices method

            int[] rolls = game.RollThree(); //Calls the RollThree method and stores the return value in the rolls array
            int sumOfRolls = 0; //Variable to hold the sum of the rolls

            for (int i = 0; i < rolls.Length; i++) //Loops through the rolls array
            {
                Debug.Assert(rolls[i] >= 1 && rolls[i] <= 6, $"Test Failed: {rolls[i]}. Roll should be between 1 and 6."); //Asserts that the roll of each dice object is between 1 and 6
                sumOfRolls += rolls[i]; //Adds the roll of each dice object to the sum of the rolls
            }

            int exceptedSum = rolls.Sum(); //Calculates the sum of the rolls
            Debug.Assert(sumOfRolls >= 3 && <= 18, $"Test Failed: {sumOfRolls}. Sum of rolls should be {exceptedSum}."); //Asserts that the sum of the rolls is equal to the expected sum
        }

        public void CheckSum(){
                 
    }
}
