using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */
        /// <value>
        /// "die1", "die2" and "die3" are all instantiations of the dice this program will use to simulate dice rolls
        /// </value>
        private Die _die1, _die2, _die3;
        /// <summary>
        /// Constructor initialises game with 
        /// </summary>
        public Game()
        {
            _die1 = new Die();
            _die2 = new Die();
            _die3 = new Die();
        }
        /// <summary>
        /// Method rolls three die objects and returns the sum
        /// </summary>
        /// <returns>
        /// Returns the sum of the 3 dice rolls (an intager between 3 and 18)
        /// </returns>
        public int Play()
        {
            int sum=0;
            sum += _die1.Roll();
            sum += _die2.Roll();
            sum += _die3.Roll();
            Console.WriteLine("Rolled 3 dice, total was "+sum);
            return sum;
        }
        /// <summary>
        /// Method continually executes "Play()" (see <see cref="Play"/> ) until the user specifies
        /// to stop.
        /// </summary>
        public void PlayContinuous()
        {
            while (true)
            {
                Play();                             // 1. do Play()
                                                    // 2. ask the user if they want to roll again
                Console.WriteLine("Do you want to roll again? (y/n)");
                while (true)                        // 2.1. repetetively ask until
                                                    // 'y'/'Y' or 'n'/'N' is responded
                {
                    var reply = Console.ReadKey().Key;
                    if (reply == ConsoleKey.Y)      // "Y" (yes) was pressed then end this loop and
                                                    // play() again
                    {
                        break;
                    }
                    else if (reply == ConsoleKey.N) // "N" (no) was pressed
                    {
                        return;                     // if "no" then end this entire function
                    }
                    else                            // else, give an error message
                    {
                        Console.WriteLine("Inalid input, Please press 'Y' or 'N'");
                    }
                }
            }
        }
    }
}
