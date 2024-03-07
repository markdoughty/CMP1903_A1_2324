using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
   
    public class Testing
    {
        public void TestDiceRolls() //test the rolls if are between 1 and 7
        {
            Die die = new Die();
            int roll = die.Roll();
            if (roll < 1 || roll > 6) // checks if number is between 1 and 7
            {
                Console.WriteLine("Die roll is not between 1 and 6."); //outputs if not
            }
            else
            {
                Console.WriteLine("Die roll is between 1 and 6."); //ouputs if its correct
            }   
        }
        public void TestGameSum()
        {
            Game game = new Game();
            int sum = game.TotalValueOfDices();
                
            if (sum < 3 || sum > 18) //checks if the sum is between 3 and 18
            {
                Console.WriteLine("The sum of the three values is not as expected.");//outputs if not
            }
            else
            {
                Console.WriteLine("The sum of the three values is as expected.");//ouputs if its correct
            }
        }
    }
    
}
