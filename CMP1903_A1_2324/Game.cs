﻿using DieGame_Assessment_1;
using System;
using System.Collections;
using System.Diagnostics;

namespace DieGame_Assessment_1
{
    // Game class
    public class Game
    {
        // Stores the random object for number generation
        private Random rng;
        // Creates the three public die objects
        public Die die1;
        public Die die2;
        public Die die3;

        // Game class constructor
        public Game()
        {
            // Initliaze the random object
            rng = new Random();
            // Creates the three dice objects (die1, die2 and die3)
            die1 = new Die(rng);
            die2 = new Die(rng);
            die3 = new Die(rng);
        }

        // Play method
        public int Play()
        {
            // Creates a new integer variable to store the total value of the dice
            int total = 0;
            
            // Rolls the three dice using the roll method and adds each value to the total
            total += die1.Roll();
            total += die2.Roll();
            total += die3.Roll();
            
            // Displays the final outputs including both the individual dice rolls and the total
            Console.WriteLine("Individual die rolls:");
            Console.WriteLine("Die 1: " + die1.CurrentValue);
            Console.WriteLine("Die 2: " + die2.CurrentValue);
            Console.WriteLine("Die 3: " + die3.CurrentValue);
            Console.WriteLine("Total of the three dice rolls: " + total);
            
            // Return the total
            return total;
        }

    }
}
