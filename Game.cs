using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public void dice_Roll();
        {
            Die die1 = new Die(); /// Creates a new die object
            Die die2 = new Die(); /// Creates a new die object
            Die die3 = new Die(); /// Creates a new die object
            roll1 = die1.die_Roll(); /// Calls the die roll method and stores the value
            roll2 = die2.die_Roll(); /// Calls the die roll method and stores the value
            roll3 = die3.die_Roll(); /// Calls the die roll method and stores the value
        }

        public int dice_Sum();
        {
            dice_Roll(); /// Calls the dice roll method
            total = roll1 + roll2 + roll3 /// Calculates the total sum of the three dice
            return total /// Returns the dice total
        }

        public void dice_Display(); 
{
            dice_Sum(); /// Calls the dice sum method
            Console.WriteLine('Die 1:', roll1) /// Displays the die roll
            Console.WriteLine('Die 2:', roll2) /// Displays the die roll
            Console.WriteLine('Die 3:', roll3) /// Displays the die roll
            Console.WriteLine('Total:', total) /// Displays the dice total
        }
    }
}
