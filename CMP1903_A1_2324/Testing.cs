using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // creating a variable to store Game class
        private readonly Game tested;

        //setting the variable tested to the game being used by the class
        public Testing(Game _tested)
        {
            //sets the tested variable to the game being tested
            tested = _tested;
        }
        //creating a private function that adds all of the numbers together and check for any inconcistencies
        private void ValidateSum()
        {
            //declaring a new array of 3 dice
            int[] DieList = tested.newDice(3);
            //adding all of the numbers using SumDice function and setting them to sum1
            int Sum1 = tested.SumDice(DieList);
            //calling the sum function again
            int Sum2 = tested.SumDice(DieList);
            //checking if the result is the same both times
            Debug.Assert(Sum1 == Sum2);
        }
        //creating a private function to check the range of numbers on the dice
        private void ValidateRange()
        {
            //calling the newDice function while only rolling 1 dice
            int[] DieList = tested.newDice(1);
            //calling the sum function to turn the DieList into an int
            int num = tested.SumDice(DieList);
            //checking if the returned number is within range
            Debug.Assert(num > 0 && num < 7);
        }
        //creating a public function that will run all of the test functions
        public void RunTest()
        {
            //Calling ValidateRange 
            ValidateRange();
            //Calling ValidateSum
            ValidateSum();
        }
    }
}
