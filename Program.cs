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
            // Create a new instance of the Game class
            Game game = new Game();

            // Roll one die then store the result
            int result = game.RollDie();
            // Print the result of the die roll
            Console.WriteLine("Die Roll value: " + result);

            // Roll three dice then print their results
            game.RollThreeDice();

            // Create a new instance of the Testing class for testing purposes
            Testing testing = new Testing();
            // Perform tests
            testing.Test();
        }
    }

    internal class Testing
    {
        // Method to perform tests
        public void Test()
        {
            // Test Game class
            TestGame();
            // Test Die class
            TestDie();
        }

        // Method to test Die class
        private void TestDie()
        {
            Console.WriteLine("Testing the Die class");

            // Die object
            Die die = new Die();

            //  die rolled three times then print the results
            for (int i = 0; i < 3; i++)
            {
                int result = die.Roll();
                Console.WriteLine("Die Roll value: " + result);
            }
        }

        // Method to test Game class
        private void TestGame()
        {
            Console.WriteLine("Testing the Game class");

            // Create a Game object
            Game game = new Game();

            // first die rolled then result is printed
            int result = game.RollDie();
            Console.WriteLine("First Die Roll value: " + result);

            // die rolled three times then print the results
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

        // Method to roll the die and return the result
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

        // Method to roll a single die then return the result
        public int RollDie()
        {
            return die.Roll();
        }

        // Method to roll three die and print their results
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
