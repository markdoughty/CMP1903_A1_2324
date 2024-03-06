using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Game
    {
        Die[] dices = new Die[3]; //Array to hold three dice objects

        public void RollDices() //Method to create three dice objects
        {
            for (int i = 0; i < 3; i++) //Loops through the array 3 times
            {
                dices[i] = new Die(); //Creates three dice objects and stores them in the dices array at positions 0, 1 and 2
            }
        }

        public int[] RollThree() //Method to roll three dice objects
        {
            int[] rolls = new int[3]; //Array to hold the rolls of the three dice objects
            int totalSum = 0;   //Variable to hold the total sum of the rolls

            for (int i = 0; i < dices.Length; i++)  //Loops through the dices array
            {
                rolls[i] = dices[i].Roll(); //Calls the Roll method on each dice object
                totalSum += rolls[i]; //Adds the roll of each dice object to the total sum
                Console.WriteLine($"Dice {i + 1}: {rolls[i]}"); //Prints the roll of each dice object
            }

            Console.WriteLine($"Total Sum: {totalSum}"); //Prints the total sum of the rolls
            return rolls;   //Returns the rolls of the three dice objects
        }

        public void ContinousDice() //Method to roll the dice continuously
        {
            bool continueRolling = true; //Variable to hold the state of the loop

            while (continueRolling) //loops while continueRolling is true
            {
                string userInput = Console.ReadLine(); //Reads the user input

                if (userInput.ToLower() == "exit") //Checks if the user input is "exit"
                {
                    continueRolling = false; //Sets continueRolling to false
                }
                else
                {
                    RollThree(); //Calls the RollThree method
                }
            }
        }

    }
}
