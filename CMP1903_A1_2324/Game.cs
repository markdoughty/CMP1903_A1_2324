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

        //Methods
        public (int, int, int, int) RollDice() // Public method to instantiate three dice and roll them. Returns the first dice's value, then second, then third, and the sum of the values, all in a tuple.
        {
            Die FirstDice = new Die(); // Instantiates a new Die object.
            int FirstValue = FirstDice.Roll(); // Declares an int to store the value returned from the call to the Roll() method of the Die object.

            Die SecondDice = new Die(); // Instantiates a new Die object.
            int SecondValue = SecondDice.Roll(); // Declares an int to store the value returned from the call to the Roll() method of the Die object.

            Die ThirdDice = new Die(); // Instantiates a new Die object.
            int ThirdValue = ThirdDice.Roll(); // Declares an int to store the value returned from the call to the Roll() method of the Die object.

            int Total = FirstValue + SecondValue + ThirdValue; // Declares a new int to store the sum of the Roll() values added together.
            return (FirstValue, SecondValue, ThirdValue, Total); // Constructs a tuple to return all the int values together.
        }
    }
}