using System;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            Game NewGame = new Game(); // Instantiates a new Game object.
            Console.Write(NewGame.RollDice()); // Outputs the values of the dice and their total to the console.

            Testing NewTest = new Testing(); // Instantiates a new Testing object.
            NewTest.StartTests(); // Calls the StartTests() method to run tests on the other classes and assert error messages if any discrepancies are found.

            Console.Read(); // Halts execution until the user presses any key. This prevents the program from terminating before the user can read the displayed values.
        }
    }
}