using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void RunTests()
        {
            TestDie();
            TestGame();
        }

        private static void TestDie()
        {
            Die die = new Die();
            die.Roll();
            Debug.Assert(die.CurrentValue >= 1 && die.CurrentValue <= 6, "Die roll result out of expected range");
        }

        private static void TestGame()
        {
            Game game = new Game();
            int total = game.RollDice();
            Debug.Assert(total >= 3 && total <= 18, "Game total out of expected range");
        }
    }
}
