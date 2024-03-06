using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// Represents a game instance with a total sum of die rolls.
    /// </summary>
    internal class Game
    {
     /* [BRIEF]
      * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
      *
      * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
      * rolls could be continous, and the totals and other statistics could be summarised for example.
      */

        //Methods
        // Property to hold the total sum of the die rolls
        public int Sum { get; private set; }

        /// <summary>
        /// Constructor create an instance of the sum of die rolls.
        /// </summary>
        public Game(Die die1, Die die2, Die die3)
        {
            int rollValue1 = die1.Roll();
            int rollValue2 = die2.Roll();
            int rollValue3 = die3.Roll();

            Sum = rollValue1 + rollValue2 + rollValue3; // Calculate the total sum of die rolls
        }
    }
}
