﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DieGame_Assessment_1
{
    // Testing class
    public class Testing
    {
        // Creates the Test method (this is called from the program class to start the game)
        public static void Test()
        {
            // Creates a new instance of the game class
            Game game = new Game();
            int total = game.Play(); // Calls the Play method from the game class

            // Debug asserting to find individual die rolls and make sure each die is within range (if not then displays a message to the user)
            Debug.Assert(game.die1.CurrentValue >= 1 && game.die1.CurrentValue <= 6, "Die 1 is out of range");
            Debug.Assert(game.die2.CurrentValue >= 1 && game.die2.CurrentValue <= 6, "Die 2 is out of range");
            Debug.Assert(game.die3.CurrentValue >= 1 && game.die3.CurrentValue <= 6, "Die 3 is out of range");

            // Debug asserting to find total and make sure its correct (assigns expected total to the values of the total from the game class)
            int expectedTotal = game.die1.CurrentValue + game.die2.CurrentValue + game.die3.CurrentValue;
            Debug.Assert(total == expectedTotal, $"Unexpected total: {total}");

            // Output message if all the tests are passed
            Console.WriteLine("Tests passed successfully.");
        }
    }

}
