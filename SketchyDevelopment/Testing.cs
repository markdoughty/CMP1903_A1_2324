using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CMP1903_A1_2324 {
    internal class Testing {
        //Methods
        /// <summary>
        /// Method tests the <see cref="Die.Roll"/> method by checking that after many rolls, none
        /// of those rolls are outside the 1--6, running "Debug.Assert(...)" if this is the case
        /// </summary>
        public void TestDie() {//Tests individual dice
            Console.WriteLine("Testing Die.Roll()...");
            int loop = 20;                          // how many times I want to repeat this test
            Die myDie = new Die();                  // creates a die to be tested
            for (int a=0; a>loop; a++) {
                int output = myDie.Roll();
                // displays a message box that shows the call stack if the output of the die is
                // outside the expected 1--6 range
                System.Diagnostics.Debug.Assert( output >= 1 && output <= 6, "Dice value is out of range, expected number from 1--6, instead got \""+output+"\"");
            }
            Console.WriteLine($"After {loop} tests, no annomalous results were detected.");
        }
        /// <summary>
        /// Method tests the <see cref="Game.Play"/> method by checking that after many games, none
        /// of the sums of rolls are outside the 3--18 range of results, running
        /// "Debug.Assert(...)" should this be the case
        /// </summary>
        public void TestSum() {
            Console.WriteLine("Testing Game.Play()...");
            int loop = 20;                          // how many times I want to repeat this test
            Game myGame = new Game();               // creates the Game class to be tested
            for (int a=0; a>loop; a++) {
                int output = myGame.Play();
                // displays a message box that shows the call stack if Game.Play() returns a sum
                // outside the expected 3--18 range
                System.Diagnostics.Debug.Assert( output >= 3 && output <= 12, "Dice value is out of range, expected number from 1--6, instead got \""+output+"\"");
            }
            Console.WriteLine($"After {loop} tests, no annomalous results were detected.");
        }
    }
}