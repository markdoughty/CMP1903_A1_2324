public class BoardGame
{
    public Dice[] dices;

    public BoardGame()
    {
        dices = new Dice[3];
        for (int i = 0; i < 3; i++)
        {
            dices[i] = new Dice();
        }
    }

    public void RollDices()
    {
        Console.Write("Individual dice rolls: ");
        int totalSum = 0;
        foreach (Dice dice in dices)
        {
            int rollResult = dice.Roll();
            Console.Write(rollResult + " ");
            totalSum += rollResult;
        }
        Console.WriteLine("\nTotal sum of dice rolls: " + totalSum);
    }
}
