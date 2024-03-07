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
        /// <summary>
        /// creates 3 new dice objects and adds them together multiple times, checking for any errors in the sum function
        /// </summary>
        private void ValidateSum()
        {
            //creating 3 dice objects
            int Die1 = tested.newDice();
            int Die2 = tested.newDice();
            int Die3 = tested.newDice();

            //calcuating the sum of the dice twice
            int Sum1 = tested.SumDice(Die1, Die2, Die3);

            int Sum2 = tested.SumDice(Die1, Die2, Die3);
            //checking if the result is the same both times
            Debug.Assert(Sum1 == Sum2);
        }
        /// <summary>
        /// checks that the dice have a valid range between 1 - 6 
        /// </summary>
        private void ValidateRange()
        {
            //calling the newDice function while only rolling 1 dice
            int Die = tested.newDice();
            //calling the sum function to turn the DieList into an int
            
            //checking if the returned number is within range
            Debug.Assert(Die > 0 && Die < 7);
        }
        /// <summary>
        /// creating a public function that will run all of the tests
        /// </summary>
        public void RunTest()
        {
            //Calling ValidateRange 
            ValidateRange();
            //Calling ValidateSum
            ValidateSum();
        }
    }
}
