using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // creates play object and starts the game

            Game play = new Game();
            Console.WriteLine(play.DiceGame());

        }
    }
}



