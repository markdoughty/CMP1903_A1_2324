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
            


            Game gm = new Game();
            var Roll = gm.myMethod();
            Die die = new Die();


            Console.WriteLine(Roll.Item1);
            Console.WriteLine(Roll.Item2);
            Console.WriteLine(Roll.Item3);



            int totalroll = Roll.Item1 + Roll.Item2 + Roll.Item3;
            Console.WriteLine(totalroll);





            Debug.Assert(Roll.Item1 < 6 && Roll.Item1 > -1, "Roll 1 is between 1 and 6");



            Debug.Assert(Roll.Item2 < 6 && Roll.Item2 > -1, "Roll 2 is between 1 and 6" );

            Debug.Assert(Roll.Item3 < 6 && Roll.Item3 > -1, "Roll 3 is between 1 and 6");



        }


    }
}