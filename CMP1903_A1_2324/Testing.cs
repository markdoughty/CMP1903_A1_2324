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

        private bool _show; //initialisation of private bool variable

        private bool show //encapsulation of bool variable 'show' so value is not changed by another class
        {
            get { return _show; }
            set { _show = value; }
        }

        //Method


        //this method tests the game class, testing if the sum of all three dice matches the expected value
        public void Game_Test()
        {
            Game g_test = new Game(); //creates a new object of the Game class
            show = false; 
            int actual = g_test.game(show); //calls 'game' method in the Game class and stores the return value in an integer variable
            int expected = g_test.roll1 + g_test.roll2 + g_test.roll3; //stores the sum of all 3 dice from the test object of the Game class

            Debug.Assert(actual == expected, "Actual value does not match expected value"); //raises a debug error if the actual value does not match the expected value
            Console.WriteLine("\nTEST 1 --> actual results match the expected results, Test Passed for Game class...");
        }

        //this method tests the Die class, testing if the values of the dice are in the correct range
        public void Die_Test()
        {
            Die d_test = new Die(); //creates new object of the Die class
            d_test.Roll(); //calls the 'Roll' function in the Die class
            Debug.Assert(d_test.value >= 1, "Die value is below range"); //raises a debug error if the value of the die is below the range (e.g - >1)
            Debug.Assert(d_test.value <= 6, "Die value is above range"); //raises a debug error if the value of the die is above the range (e.g - <6)

            Console.WriteLine("TEST 2 --> roll for test die is in boundries of 1-6, Test Passed for Die class...");
        }
    }
}
