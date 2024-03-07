using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    // testActive created to stop console.WriteLine statements in Game class from running twice
    public class globalTestActive
    {
        public static bool testActive = false;
    }

    internal class Program
    {
        public static void Main(string[] args)
        {

            Testing testing = new Testing();

            // creates play object and starts the game.

            Game play = new Game();
            Console.WriteLine("Total: " + play.DiceGame());

        }
    }
}



