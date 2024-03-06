using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This code creates the game object and calls its methods.
            Game game = new Game();
            int total = game.RollAndReportTotal();
            Console.WriteLine("The total of the three dice rolls is: " + total);

            // This code optionally creates a testing object to verify the output and operation of other classes.
            Testing testing = new Testing();
            testing.RunTests();
        }
    }

    internal class Testing
    {
        // This class can be used to run tests on other classes.
        public void RunTests()
        {
            // As an option, you can add tests here to verify the output and operation of other classes.
            // Die die = new Die();
            // die.Roll();
            // Console.WriteLine("The face value of the die is: " + die.FaceValue);
        }
    }
}
