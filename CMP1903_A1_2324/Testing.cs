using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Testing
    {
        public static void Testings()
        {
            Gametest();
            Dietest();
        }

        public static void Dietest()
        {
            //test the reult of the dice roll to see of it is in range 
            Die die = new Die();
            die.diceroll();
            int total = die.fetchvalue();
<<<<<<< HEAD
            Debug.Assert(total >=1 && total <= 6, "the die that was rolled did not fall within range and did not work as intended");
=======
            Debug.Assert(total >= 1 && total <= 6, "the die that was rolled did not fall within range and did not work as intended");
>>>>>>> master
        }
        public static void Gametest()
        {
            //test the reult of the game to see of it is in range 
            Game game = new Game();
            int total = game.Sum();
<<<<<<< HEAD
            Debug.Assert(total>=3 && total <=18, "the dice did not add up correctly and did not function as intended");
        }
        
=======
            Debug.Assert(total >= 3 && total <= 18, "the dice did not add up correctly and did not function as intended");
        }

>>>>>>> master
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
    }
}
