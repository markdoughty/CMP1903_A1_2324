using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace CMP1903_A1_2324
{
    public class Testing
    {
        public static void Test()
        {
            Game game = new Game();
            int total = game.Play();

            // Debug asserting to find individual die rolls
            Debug.Assert(game.die1.CurrentValue >= 1 && game.die1.CurrentValue <= 6, "Die 1 is out of range");
            Debug.Assert(game.die2.CurrentValue >= 1 && game.die2.CurrentValue <= 6, "Die 2 is out of range");
            Debug.Assert(game.die3.CurrentValue >= 1 && game.die3.CurrentValue <= 6, "Die 3 is out of range");

            // Debug asserting to find total and make sure its correct (assigns expected total to the values of the total from the game class)
            int expectedTotal = game.die1.CurrentValue + game.die2.CurrentValue + game.die3.CurrentValue;
            Debug.Assert(total == expectedTotal, $"Unexpected total: {total}");

            Console.WriteLine("Tests passed successfully.");
        }
    }

}
