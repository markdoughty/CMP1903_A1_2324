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
        //
        public static void Main(string[] args)
        {
            int roll1 = 0;
            int roll2 = 0;
            int roll3 = 0;

            Game gm = new Game();
            Die die = new Die();
            roll1 = gm.myMethod(0, 0);
            roll2 = gm.myMethod(1, 1);
            roll3 = gm.myMethod(2, 1);

            
           
            
            
            Debug.Assert(roll1 <= 6 , "Die rolls are between 1 and 6" );
            Debug.Assert(roll2 <= 6 , "Die rolls are between 1 and 6" );
            Debug.Assert(roll3 <= 6 , "Die rolls are between 1 and 6" );

        }

    }
}