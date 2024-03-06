using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Die[] dice;
        public int Total { get; private set; }

        // Constructor to create three dice objects
        public Game()
        {
            dice = new Die[3];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }

        // Method to roll all three dice, sum their values, and report the total
        public void RollDiceAndReportTotal()
        {
            Total = 0;
            Console.WriteLine("Rolling the dice...");
            foreach (Die die in dice)
            {
                int result = die.Roll();
                Console.WriteLine($"Die rolled: {result}");
                Total += result;
            }
            Console.WriteLine($"Total of three dice rolls: {Total}");
        }
    }
}

