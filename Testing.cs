using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private int sum
        private int roll

        public void test_Game(); /// Tests the game class
        {
            Game game = new Game(); /// Creates a new game object
            sum = game.dice_Sum(); /// Calls the dice sum method and assigns it to sum
            Debug.Assert(sum >= 3 && sum <= 18, 'Invalid die sum'); /// Checks that the sum is within range 
        }

        public void test_Die(); /// Tests the die class
        {
            Die die = new Die(); /// Creates a new die object
            roll = game.die_Roll(); /// Calls the die roll method and assigns it to roll
            Debug.Assert(roll >=1 && roll <=6, 'Invalid die roll'); /// Checks that the roll is within range
        }   
    }
}
