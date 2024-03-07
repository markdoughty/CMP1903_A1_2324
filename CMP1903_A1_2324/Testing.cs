using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
       public class Testing
        {
            public void TestDiceRolls()
            {
                Die die = new Die();
                int roll = die.Roll();
                if (roll < 1 || roll > 6)
                {
                    Console.WriteLine("Die roll is not between 1 and 6.");
                }
                else
                {
                    Console.WriteLine("Die roll is between 1 and 6.");
                }
            }
            public void TestGameSum()
            {
                Game game = new Game();
                int sum = game.TotalValueOfDices();
                
                if (sum < 3 || sum > 18)
                {
                    Console.WriteLine("The sum of the three values is not as expected.");
                }
                else
                {
                    Console.WriteLine("The sum of the three values is as expected.");
                }
            }
        }
    }
}
