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
            // rolls the die and then stores the result
            int result = game.RollDie();
            // prints result of die roll
            Console.WriteLine("Die roll value: " + result);
        }
    }

    internal class Die
    {
        private int currentValue; // shows what the current value of the die is
        private Random random; 

        public int Value { get { return currentValue; } }
        public Die()
        {
            random = new Random(); 
            Roll(); // gets the die to roll when created
        }

        public int Roll()
        {
            // random number from between 1- 6 and displays the result as the current value
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
            return die.Roll(); // rolls the die for the result to be shown
        }
    }
}










/*
 * The Die class should contain one property to hold the current die value,
 * and one method that rolls the die, returns and integer and takes no parameters.
 */

//Property


//Method



