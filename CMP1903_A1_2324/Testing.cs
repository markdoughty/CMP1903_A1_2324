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
            Debug.Assert(Array.TrueForAll(rolls, roll => roll >= 1 && roll <= 6), "Die rolls are not between 1 and 6."); //checks if dice is rools between 1 and 6
        }
        public void TestGameSum()
        {
            Game game = new Game();
            int sum = game.TotalValueOfDices();
                
            Debug.Assert(sum >= 3 && sum <= 18, "Sum of the three values is not as expected."); // checks if sum of dice is between 3 and 18
        }
    }
    
}
