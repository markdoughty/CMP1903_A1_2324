using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    /// <summary>
    /// This code represents a game that involves rolling three dice and calculating the sum of their values.
    /// </summary>
    internal class Game
    {
        private int _sumOfRolls { get;  set; }

        /// <summary>
        /// Initialises the game with the sum of die rolls. 
        /// </summary>


        //This is a constructor
        public Game(int rollValue1, int rollValue2, int rollValue3)
        {
            _sumOfRolls = rollValue1 + rollValue2 + rollValue3;
        }
    }
}
/*
 * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
 *
 * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
 * rolls could be continuous, and the totals and other statistics could be summarized, for example.
 */
