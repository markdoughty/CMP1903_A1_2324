using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int result = game.RollDie();
            Console.WriteLine("Die roll value: " + result);

            game.RollThreeDice(); // Call the method to roll three dice
        }
    }

    internal class Game
    {
        private Die dice1 = new Die();
        private Die dice2 = new Die();
        private Die dice3 = new Die();

        public int RollDie()
        {
            return dice1.Roll();
        }

        public void RollThreeDice()
        {
            int x = dice1.Roll();
            int y = dice2.Roll();
            int z = dice3.Roll();

            Console.WriteLine($"first die roll result: {x}");
            Console.WriteLine($"second die roll result: {y}");
            Console.WriteLine($"third die roll result: {z}");

            int sum = x + y + z;
            Console.WriteLine($"The sum of the three rolls of die is " + sum);
        }
    }

    internal class Die
    {
        private Random random;

        public Die()
        {
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, 7);
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
