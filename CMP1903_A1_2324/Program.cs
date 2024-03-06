namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int total = game.RollDice();
            System.Console.WriteLine($"Total of three dice rolls: {total}");

            Testing.RunTests();
        }
    }
}
