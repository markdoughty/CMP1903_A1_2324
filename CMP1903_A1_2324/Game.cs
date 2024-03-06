using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    static void Main()
    {
        Die die1 = new Die();
        Die die2 = new Die();
        Die die3 = new Die();

        bool continueRolling = true;

        while (continueRolling)
        {
            int numberOfRolls = 3;

            Tester.TestDieValues(die1, numberOfRolls);
            Tester.TestDieValues(die2, numberOfRolls);
            Tester.TestDieValues(die3, numberOfRolls);

            for (int i = 0; i < numberOfRolls; i++)
            {
                int rollResult1 = die1.RollDie();
                int rollResult2 = die2.RollDie();
                int rollResult3 = die3.RollDie();

                int totalSum = rollResult1 + rollResult2 + rollResult3;

                Console.WriteLine($"Roll {i + 1}: Die1: {rollResult1}, Die2: {rollResult2}, Die3: {rollResult3}, Total: {totalSum}");
            }

            Console.WriteLine("Type 'continue' to roll again or any other key to exit:");
            string userInput = Console.ReadLine();

            if (!userInput.ToLower().Equals("continue"))
            {
                continueRolling = false;
            }
        }
    }
}
