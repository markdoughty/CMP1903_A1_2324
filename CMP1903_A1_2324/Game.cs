
using System;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Now creating three different Die objects
        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();

        // This method is to perform the dice rolls, sum the results, and report the Total
        public int RollAndSumDice()
        {
            // To roll each die
            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();

            // Sum the results
            int total = roll1 + roll2 + roll3;

            // This section reports the total
            Console.WriteLine($"Die 1: {roll1}, Die 2: {roll2}, Die 3: {roll3}");
            Console.WriteLine($"Total: {total}");

            return total;
        }
    }
}
