using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Testing
    {
        public void Test()
        {
            //Creating a Game object
            Game GameTest = new Game();

            GameTest.DieCreator();

            Die DieTest = new Die();
            DieTest.DieValue = DieTest.Roll();
            Console.WriteLine("\nDie Test: " + DieTest.DieValue);
            Console.WriteLine("Press any key to exit...");

            Debug.Assert(DieTest.DieValue > 0 && DieTest.DieValue < 7);
            Debug.Assert(GameTest.result == GameTest.Die1.DieValue + GameTest.Die2.DieValue + GameTest.Die3.DieValue);
        }
    }
}
