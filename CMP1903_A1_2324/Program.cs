using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // created game object
            Game play = new Game();
            // method called
            Console.WriteLine(play.DiceGame());
           


            // currently, the same number is being assigned to each die roll
            // RollDie method in Die.cs needs to be fixed to allow more than 1 dieroll number.
            // Outputs total twice

            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        }
    }
}
