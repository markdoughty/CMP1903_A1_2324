using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        public void Test()
        {
            //Creating a Game object
            Game GameTest = new Game();

            GameTest.DieCreator();

            //creates a new Die object
            Die DieTest = new Die();
            //uses the method Roll() in the Die class to generate a random number between 1-6 i.e. rolling the die
            DieTest.DieValue = DieTest.Roll();

            //outputs die value to screen
            Console.WriteLine("\nDie Test: " + DieTest.DieValue);
            Console.WriteLine("Press any key to exit...");

            //ensures that DieValue is between 1-6 inclusive, if they are there will be no effect
            Debug.Assert(DieTest.DieValue > 0 && DieTest.DieValue < 7);
            //checks the total of all the dice is equal to the values of Die1 + Die2 + Die3
            Debug.Assert(GameTest.result == GameTest.Die1.DieValue + GameTest.Die2.DieValue + GameTest.Die3.DieValue);
        }
    }
}
