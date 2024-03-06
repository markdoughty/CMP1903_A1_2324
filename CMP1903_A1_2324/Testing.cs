using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        class Tester
        {
            public static void TestDieValues(Die die, int iterations)
            {
                for (int i = 0; i < iterations; i++)
                {
                    int result = die.RollDie();
                    Debug.Assert(result >= 1 && result <= 6, "Die value out of range");
                }

                Console.WriteLine("Die values are within the valid range.");
            }
        }
    }
}
