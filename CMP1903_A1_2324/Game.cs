using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Program
    {
        static void Main(string[] args)
        {
            // new instance of  Game class
            Game game = new Game();
            // Roll one die and store the result
            int result = game.RollDie();
            // Prints the result of the die roll
            Console.WriteLine("Die roll value: " + result);

            // method to roll three dice
            game.RollThreeDice();
        }
    }

    internal class Game
    {
        private Die dice1 = new Die(); 

        // Method to roll one die
        public int RollDie()
        {
            return dice1.Roll(); // rolls the first die
        }

        // Method to roll three dice
        public void RollThreeDice()
        {
            // Roll each die then stores results
            int x = dice1.Roll();
            int y = dice1.Roll();
            int z = dice1.Roll();

            // Print result after each die roll
            Console.WriteLine($"First die roll result: {x}");
            Console.WriteLine($"Second die roll result: {y}");
            Console.WriteLine($"Third die roll result: {z}");

            // calculates sum of three die rolls then prints result of sum
            int sum = x + y + z;
            Console.WriteLine($"The sum of the three rolls of the die is " + sum);
        }
    }

    internal class Die
    {
        private Random random;

       
        public Die()
        {
            random = new Random(); 
        }

        // Method to roll the die then return result
        public int Roll()
        {
            return random.Next(1, 7); // random number between 1 and 7 generated
        }
    }
}


        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods

    }
}
