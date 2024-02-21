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

        //Method
        public void StartTests() // Public method to instantiate a Game object and test all of its outputs.
        {
            Game NewGame = new Game(); // Instantiates the Game object.
            (int, int, int, int) GameValues = NewGame.RollDice(); // Declares an int tuple to store the results from the rolls, and gets the values for it from a call to the RollDice() method.
            (bool, bool, bool, bool) Checks = CheckAllValues(GameValues); // Declares a bool tuple to store the results from the checks, and gets those results from the CheckAllValues() method. GameValues is passed as an argument.

            // Calls Debug.Assert() with each of the Checks values, and outputs error messages if any of them are false.
            Debug.Assert(Checks.Item1, $"Error: the first dice roll returned a value of {GameValues.Item1}!");
            Debug.Assert(Checks.Item2, $"Error: the second dice roll returned a value of {GameValues.Item2}!");
            Debug.Assert(Checks.Item3, $"Error: the third dice roll returned a value of {GameValues.Item3}!");
            Debug.Assert(Checks.Item4, $"Error: the sum of the dice rolls returned a value of {GameValues.Item4}!");
        }
        public bool CheckRollValue(int RollValue)
        {
            if (RollValue < 1 || RollValue > 6) return false;
            else return true;
        }
        public bool CheckTotalValue((int, int, int, int) GameValues)
        {
            if (GameValues.Item1 + GameValues.Item2 + GameValues.Item3 == GameValues.Item4) return true;
            else return false;
        }
        public (bool, bool, bool, bool) CheckAllValues((int, int, int, int) GameValues)
        {
            bool FirstRoll = CheckRollValue(GameValues.Item1);
            bool SecondRoll = CheckRollValue(GameValues.Item2);
            bool ThirdRoll = CheckRollValue(GameValues.Item3);
            bool Game = CheckTotalValue(GameValues);
            return (FirstRoll, SecondRoll, ThirdRoll, Game);
        }
    }
}