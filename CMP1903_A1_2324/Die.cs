public class Dice
{
    private Random random;
    public int FaceValue { get; private set; }

    public Dice()
    {
        random = new Random();
    }

    public int Roll()
    {
        FaceValue = random.Next(1, 7); // Generates a random number between 1 and 6
        return FaceValue;
    }
}
