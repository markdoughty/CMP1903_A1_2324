using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private static Random random = new Random();
        public void TestDieGame()
        {

            // Test Die class
            Die die = new Die(random);
            int dievalue = die.Roll();
            Debug.Assert(dieValue >= 1 && dievalue <= 6, die"Die roll value is" + dievalue + " and not within expected range.");

            // Test Game class
            Game game = new Game();
            int total = game.RollTotal();
            Debug.Assert(total >= 3 && total <= 18, "The sum of 3 dice rolls is " + total + " and not within expected range.");
        }
    }
}
}
