using System;
using System.Collections;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    public class Game
    {
        // gets random and creates 3 public die objects
        private Random random;
        public Die die1;
        public Die die2;
        public Die die3;

        public Game()
        {
            // assigns each die using the die class
            random = new Random();
            die1 = new Die(random);
            die2 = new Die(random);
            die3 = new Die(random);
        }

        public int Play()
        {
            // displays the values for each die and the total
            int total = 0;
            Console.WriteLine("Individual die rolls:");
            total += die1.Roll();
            Console.WriteLine("Die 1: " + die1.CurrentValue);
            total += die2.Roll();
            Console.WriteLine("Die 2: " + die2.CurrentValue);
            total += die3.Roll();
            Console.WriteLine("Die 3: " + die3.CurrentValue);
            Console.WriteLine("Total of the three dice rolls: " + total);
            return total;
        }

    }
}
