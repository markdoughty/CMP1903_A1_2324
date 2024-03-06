using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public void Program()
    {
        int total = 0; //Sets the total of the combined dice to 0 so it has a value

        Console.WriteLine("The following amount of Dice are being rolled..."); //Allows the user to see that the following dice are being rolled

        for (int x = 0; x < 3; x++) //For loop to run the dice rolls until the specified number has been met which is 3 dice
        {
            int roll_value = dice[x].Roll(); //Sets the roll_value equal to the result of the roll function in the Die class
            Console.WriteLine($"Die {x + 1} Value: {roll_value}"); //Displays which die rolled what value for the user
            total += roll_value; //Totals up the value of all the dice combined and gives a accumulative sum
        }

        Console.WriteLine($"Total sum of all dice rolls combined: {total}"); //Displays the total to the user so they can see the score
        Debug.Assert(total >= 3 && total <= 18, "Total is greater or less than the possible combination of totals."); //Checks to make sure that the value cannot be creater than 18 or less that 3 as its not in the possible combination of die roll totals
    }
}
