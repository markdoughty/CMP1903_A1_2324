using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // Entry point of the program
        public static void Main(string[] args)
        {
            // runs the tests which is for the die if it's biased to even or odd numbers when rolled 100 times
            RunTests();
        }

        internal class Die
        {
            private Random random;

            public Die()
            {
                random = new Random();
            }

            public int Roll()
            {
                return random.Next(1, 7); // Returns a random number between 1 and 6
            }
        }

        public static void RunTests()
        {
            // tests the Die class
            Die die = new Die();

            // counts the odd and even rolls out of 100 times
            int oddnumberCount = 0;
            int evennumberCount = 0;

            // rolls the die 100 times
            for (int i = 0; i < 100; i++)
            {
                int rollResult = die.Roll();

                if (rollResult % 2 == 0)
                {
                    evennumberCount++;
                }
                else
                {
                    oddnumberCount++;
                }
            }

            // shows the message depending if the die is biased towards odd, even, or fair
            string testResult;
            if (oddnumberCount > evennumberCount)
            {
                testResult = "The die is biased towards odd numbers.";
            }
            else if (evennumberCount > oddnumberCount)
            {
                testResult = "The result from the test shows the die is biased towards even numbers.";
            }
            else
            {
                testResult = "The result from the test shows the die is fair.";
            }

            Console.WriteLine(testResult);
        }
    }
}
        
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        //
    }
}
