using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
       

        public void DieTestResult()  // Creates a public method called DieTestResult, void is used as no return value needed 
        {
            Die die = new Die(); // New instance of Die class created 
            int DieRoll = die.Roll(); // runs the Roll method in Die class and saves result to varible DieRoll
            
            
            Debug.Assert(DieRoll > 0, "Die roll is less than 0"); // Use of Debug.Assert to ensure the rolled die value is between 1,6 (As die used is D6)
            Debug.Assert(DieRoll < 7, "Die roll is more than 7");


        }

        public void GameTestResult() // Creates public method GameTestResult and use of void due to no return value
        {

            Game game = new Game(); // create instance of Game class
            int DieTotal = game.DieSum(); // save the result from DieSum method in Game class to variable DieTotal
            


            Debug.Assert(DieTotal > 2, "Die sum is < 3 "); // Debug.Assert used to ensure the DieSum is between 3 and 18 as that is highest/lowest possible combination of die numbers
            Debug.Assert(DieTotal < 19, "Die sum is > 18 ");

        }


    }   
}
