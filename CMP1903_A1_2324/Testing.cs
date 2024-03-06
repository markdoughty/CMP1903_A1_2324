public class Tester
{
    public static void PerformTest()
    {
        BoardGame boardGame = new BoardGame();
        boardGame.RollDices();

        // Verify that dice rolls are between 1 and 6
        foreach (Dice dice in boardGame.dices)
        {
            Debug.Assert(dice.FaceValue >= 1 && dice.FaceValue <= 6, "Dice roll out of range");
        }

        // Verify that the sum of the three dice face values is as expected
        int expectedTotalSum = 0;
        foreach (Dice dice in boardGame.dices)
        {
            expectedTotalSum += dice.FaceValue;
        }
        Debug.Assert(expectedTotalSum >= 3 && expectedTotalSum <= 18, "Total sum of dice rolls out of range");

        Console.WriteLine("Testing completed.");
    }
}
