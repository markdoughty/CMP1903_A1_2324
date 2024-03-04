using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        
         // This class should test the Game and the Die class.
         // Create a Game object, call the methods and compare their output to expected output.
         // Create a Die object and call its method.
         // Use debug.assert() to make the comparisons and tests.
  

        //Method


        public void test()
        {
            Game testGame = new Game();
            //creates object from the class "Game"

            testGame.DieCreation();
            //runs object's method

            Die testDie = new Die();
            testDie.diceValue = testDie.Roll();
            Console.WriteLine("Test Roll:  "+testDie.diceValue);
            //creates object from the class "Die" then runs its method and displays it on screen
            Debug.Assert(testDie.Roll() < 7 && testDie.Roll() > 0);
        }  
    }
}
