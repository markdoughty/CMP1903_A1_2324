using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        //This section of code is using the "Die" class to instantiate three new dice to be rolled later with the "RollTheDice" method
        Die DieNumOne = new Die();
        Die DieNumTwo = new Die();
        Die DieNumThree = new Die();

        //This section of code is using the "RollTheDice" method to store the value of the rolled Dice into an array where they can be accessed
        public int[] AllDieRolls()
        {
            int DieRollOne = DieNumOne.RollTheDice();
            int DieRollTwo = DieNumTwo.RollTheDice();
            int DieRollThree = DieNumThree.RollTheDice();
            return new int[] {DieRollOne, DieRollTwo, DieRollThree}; //This return line creates a new array of integers containing the value of each roll of the dice
        }

        public int RollTotal(int[] n) //Creating a public integer value which intakes the array of dice roll values
        {
            return n[0] + n[1] + n[2]; //Adding together the stored values of the dice rolls to create the desired outcome
        }

        //Printing the sum of the die as well as  the "extra task" of the individual dice rolls being printed
        public void Results(int[] n)
        {
            //Printing the individual results from the array creates in "AllDieRolls"
            Console.WriteLine("The first die roll result is: " + n[0]);
            Console.WriteLine("The second die roll result is: " + n[1]);
            Console.WriteLine("The third die roll result is: " + n[2]);
            //Printing the total of all the die rolls by calling method "RollTotal"
            Console.WriteLine("Therefore, the sum of all three die is: " + RollTotal(n));
        }
    }
}
