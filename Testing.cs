using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public static void TestDie()
        {
            Die die = new Die();
            int initialDieValue = die.CurrentValue;
            Debug.WriteLine($"Initial value of die: {initialDieValue}");
            int rollResult = die.Roll();
            int afterRollDieValue = die.CurrentValue;
            Debug.WriteLine($"After rolling, die value: {afterRollDieValue}");
            Debug.WriteLine($"Roll result: {rollResult}");

            // Test if die value changed after roll
            Debug.Assert(initialDieValue != afterRollDieValue, "Die value did not change after roll.");
        }

        public static void TestGame()
        {
            Game game = new Game();
            game.Play();
            // For simplicity, since Game.Play() is a gameplay loop, we don't assert anything here.
        }