using System;

namespace CMP1903_A1_2324
{

    internal class Game
    {

        public int DiceGame()
        {

            // 3 objects created from Die class.
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();

            // initiate roll
            int roll1 = die1.Roll();
            int roll2 = die2.Roll();
            int roll3 = die3.Roll();

            // does not print result if test is active
            if (Program.isTesting == false)
            {
                Console.WriteLine("Die 1: " + roll1);
                Console.WriteLine("Die 2: " + roll2);
                Console.WriteLine("Die 3: " + roll3);
            }

            // sum of 3 dice rolls
            int RollTotal = roll1 + roll2 + roll3;

            // converts total to string so it can be printed
            RollTotal.ToString();
            return RollTotal;


        }
    }
}