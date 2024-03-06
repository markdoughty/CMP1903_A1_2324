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

        /* the die test works the same way as the testGame but checks a single die*/
        private void testDie()
        {
            Die die = new Die();
            int DieResult = die.Roll();

            Debug.Assert(DieResult >= 1 && DieResult <= 6, "invalid Die Value");

            Console.WriteLine($" test die roll result: {DieResult}");
        }
        /* this error handling works by using the Debug.assert to take the 
         seperate roll's total value and checking against the min/max
        roll if it is within the range it wil show the test total if its
        not within the range it will throw up an error message*/
        private void testGame()
        {
            Game game = new Game();
            int Total = game.DiceTotal();
            //int Total = 1; <--this was used force an error allowing to check if the error handling worked properly
            Debug.Assert(Total >= 3 && Total <= 18, "invalid roll total");
            Console.WriteLine($" test roll total is {Total}");
        }
        //calls the functions
        public Testing()
        {
            testDie();
            testGame();
        }
    }
}
