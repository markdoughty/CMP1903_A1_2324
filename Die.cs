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
            Game game = new Game();
            int result = game.RollDie();
            Console.WriteLine("Die roll value: " + result);
        }
    }

    internal class Die
    {
        private int currentValue;
        private Random random;

        public int Value { get { return currentValue; } }

        public Die()
        {
            random = new Random();
            Roll();
        }

        public int Roll()
        {
            currentValue = random.Next(1, 7);
            return currentValue;
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
    }
}










/*
 * The Die class should contain one property to hold the current die value,
 * and one method that rolls the die, returns and integer and takes no parameters.
 */

//Property


//Method



