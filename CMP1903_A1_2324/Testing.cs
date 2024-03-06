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
        // This is a method to test the Games class.
        public void TestGame()
        {
            // This code creates a new Game object.
            Game game = new Game();
            
            // This code calls the RollAndReportTotal() method.
            int total = game.RollAndReportTotal();
            
            // This part of the code compares the actual output to the output that is expected.
            Debug.Assert(total >= 3 && total <= 18, "Unexpected total value.");
        }

        // Method to test the Die class
        public void TestDie()
        {
            // Create a Die object
            Die die = new Die();
            
            // Roll the die
            die.Roll();
            
            // Compare the face value to the expected range
            Debug.Assert(die.FaceValue >= 1 && die.FaceValue <= 6, "Unexpected die face value.");
        }

        // Main method to run the tests
        static void Main(string[] args)
        {
            Testing testing = new Testing();
            testing.TestGame();
            testing.TestDie();

            Console.WriteLine("Tests completed successfully.");
        }
    }
}
