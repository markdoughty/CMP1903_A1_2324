using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        

        //Methods
        public int Start()
        {
            
            int total = 0; // Variable to store the sum of rolls

            for (int i = 0; i < 3; i++)
            {
                Die die = new Die();
                int roll = die.Roll(); // Roll the die

                total += roll; // Add the roll to the total

                Console.WriteLine($"die {i + 1} is: {roll}"); // Print the output of each roll
            }

            Console.WriteLine("total is: " + total); // Print the total

            return total;// returns the sum of the rolls

        }
        // <black-eye-inc>
        // I'd recommend also adding EXTRA functionality "continuous roll method" -- this is basically
        // a function that runs your "Start()" method and then asks the user if they'd like to roll
        // again or exit the function.
        // </black-eye-inc>

    }
}
