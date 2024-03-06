using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public void Program()
    {
        int total = 0; //Sets the initial total to 0 to have a value

        Console.WriteLine($"Rolling {numberOfDice} dice..."); //specifies the total number of dice to the user

        for (int x = 0; x < num_Dice; x++) //For loop to make sure that it does not roll over or under the specified amount of dice
        {
            int rollValue = dice[x].Roll(); //Sets the roll value equal to the value that each die has been rolled
            Console.WriteLine($"Die {x + 1} Value: {rollValue}"); //Specifies to the user what each die rolled
            total += rollValue; //Totals up the value of all the dice combined and gives a accumulative sum
        }

        Console.WriteLine($"Total sum of all dice rolls combined: {total}"); //displays the total to the user

        Debug.Assert(total >= numberOfDice && total <= numberOfDice * 6,
                     $"Total is greater or less than the possible combination of totals ({numberOfDice} to {numberOfDice * 6})."); //Checks to make sure that the value cannot be creater than 18 or less that 3 as its not in the possible combination of die roll totals
    }
}
