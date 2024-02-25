using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


        //declare the sum total variable
        public int sumtotal = 0;
        //Methods
        public int[] roll3()
        {
            //create a new die 
            Die Die1 = new Die();
            //roll the die
            Die1.Roll();
            //wait 1 thousandth of a second to allow device clock to change to allow for multiple random numbers
            Thread.Sleep(1);
            //repeat for second die
            Die Die2 = new Die();
            Die2.Roll();
            Thread.Sleep(1);
            //repeat for third die minus the delay as it is unnecissary 
            Die Die3 = new Die();
            Die3.Roll();
            //save the rolled values as variables for easier usage
            int dice1 = Die1.rolledvalue;
            int dice2 = Die2.rolledvalue;
            int dice3 = Die3.rolledvalue;
            //display the rolled numbers to the user
            Console.WriteLine("rolls");
            Console.WriteLine(dice1);
            Console.WriteLine(dice2);
            Console.WriteLine(dice3);
            //calculate a total for the rolls
            sumtotal += Die1.rolledvalue + Die2.rolledvalue + Die2.rolledvalue;
            //display the total to the user
            Console.WriteLine("total of rolls");
            Console.WriteLine(sumtotal);
            //compile the rolls and and total for the testing data
            int[] answers = { sumtotal, dice1, dice2, dice3 };
            //return the data
            return answers;
        }

        //to allow for single rolls a second method is used
        public void roll1()
        {
            //create a die
            Die Die1 = new Die();
            //roll the die
            Die1.Roll();
            //read the roll to the user
            Console.WriteLine("new roll");
            Console.WriteLine(Die1.rolledvalue);
            //increment the total accordingly
            sumtotal += Die1.rolledvalue;
            //read the new total to the user
            Console.WriteLine("ne total");
            Console.WriteLine(sumtotal);
        }
    }
}
