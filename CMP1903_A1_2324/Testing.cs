using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public static void DieTest()
        {
            Die die = new Die();
            int outcome = die.Roll();

            Debug.Assert(outcome < 1 || outcome >= 7, "Die test failed");
            
            
            
        }

        public static void GameTest()
        {
            Game game = new Game();
            Console.WriteLine("Test 1");
            string test1 = game.PLay(); //first game test
            Console.WriteLine(" ");
            Console.WriteLine("Test 2");
            string test2 = game.PLay(); //second game test

            Debug.Assert(test1 == test2, "Game test Failed"); //here they're both compared
        }
        
    }
}
