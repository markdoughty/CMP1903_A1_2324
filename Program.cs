using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            int result = game.RollDie();
            Console.WriteLine("Die Roll value: " + result);
            game.RollThreeDice();

            Testing testing = new Testing();
            testing.Test();
        }
    }

    internal class Testing
    {
        public void Test()
        {
            TestGame();
            TestDie();
        }

        private void TestDie()
        {
            Console.WriteLine("Testing the Die class");

            Die die = new Die();

            for (int i = 0; i < 3; i++)
            {
                int result = die.Roll();
                Console.WriteLine("Die Roll value: " + result);
            }
        }

        private void TestGame()
        {
            Console.WriteLine("Testing the Game class");

            Game game = new Game();

            int result = game.RollDie();
            Console.WriteLine("First Die Roll value: " + result);

            game.RollThreeDice();
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

    internal class Game
    {
        private Die die;

        public Game()
        {
            die = new Die();
        }

        public int RollDie()
        {
            return die.Roll();
        }

        public void RollThreeDice()
        {
            Console.WriteLine("Rolling three dice:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Die Roll value: " + die.Roll());
            }
        }
    }
}

            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        }
    }
}
