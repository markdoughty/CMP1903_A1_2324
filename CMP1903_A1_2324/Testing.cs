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
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        
       

        public void DieTestResult()
        {
            Die die = new Die();
            int DieRoll = die.Roll();
            
            
            Debug.Assert(DieRoll > 0, "Die roll is less than 0");
            Debug.Assert(DieRoll < 7, "Die roll is more than 7");


        }

        public void GameTestResult()
        {

            Game game = new Game();
            int DieTotal = game.DieSum();
            


            Debug.Assert(DieTotal > 2, "Die sum is < 3 ");
            Debug.Assert(DieTotal < 19, "Die sum is > 18 ");

        }


    }   
}
