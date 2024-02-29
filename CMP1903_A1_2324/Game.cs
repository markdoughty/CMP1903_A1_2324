using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        public string PLay()
        {
            Die die1 = new Die(); //here three new Die are created
            Die die2 = new Die();
            Die die3 = new Die();

            int roll1 = die1.Roll(); //and they're rolled here
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();

            int total = roll1 + roll2 + roll3; //and they're totalled here
            
            Console.WriteLine("die 1 is: " + roll1);
            Console.WriteLine("die 2 is: " + roll2);
            Console.WriteLine("die 3 is: " + roll3);
            Console.WriteLine("total is: " + total); //these blocks shows the output of the Die rolls
                
            return $"die 1 is: {roll1}\ndie 2 is: {roll2}\ndie 3 is: {roll3}\ntotal is: {total}"; //this returens the game class output which will be used in the testing class
        }

    }
}
