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

        public int _roll1; //creates 3 fields so the testing class can access the value of each individual dice roll
        public int _roll2;
        public int _roll3;

        private int _total; //initialisation of private integer to store sum of all 3 dice

        public int roll1 //creates 3 properties of all 3 rolls which will store the value of each dice roll
        {
            get { return _roll1; }
            set { _roll1 = value; }
        }
        public int roll2
        {
            get { return _roll2; }
            set { _roll2 = value; }
        }
        public int roll3
        {
            get { return _roll3; }
            set { _roll3 = value; }
        }

        private int total //encapsulation of integer variable 'total' so value is not affected by other classes
        {
            get { return _total; }
            set { _total = value; }
        }

        //Methods


        //this method rolls all three dice and returns the sum of all 3 values
        public int game(bool show) //initialises method 'game' 
        {
            Die d1 = new Die(); //creates 3 objects of the Die class
            Die d2 = new Die();
            Die d3 = new Die();

            d1.Roll(); //calls the 'Roll' method in the Die class under the object 'd1'
            roll1 = d1.value; //stores the die value in a public integer
            d2.Roll(); //calls the 'Roll' method in the Die class under the object 'd2'
            roll2 = d2.value;
            d3.Roll(); //calls the 'Roll' method in the Die class under the object 'd3'
            roll3 = d3.value;

            if (show == true) //checks the boolean value 'show' if the value of each die should be displayed to the user
            {
                Console.WriteLine($"\nDie 1 = {roll1}"); //outputs the value of each die to the user
                Console.WriteLine($"Die 2 = {roll2}");
                Console.WriteLine($"Die 3 = {roll3}");
            }

            total = roll1 + roll2 + roll3; //adds up the sum of all three dice

            if (total < 3) //checks if total sum of dice is a high enough number
            {
                throw new Exception("total cannot be lower than 3"); //throws a new exception with an error message
            }
            else //if value is high enough, returns the value as normal
            {
                return total; //returns the sum of all three dice stored the integer variable 'total'
            }
        }
    }
}
