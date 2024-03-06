using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        private int _gameSum = 0;
        private int _numOfRolls = 0; 

        private Die _die1 = new Die(); 
        private Die _die2 = new Die();
        private Die _die3 = new Die();

        //created the three die objects 

        private int _roll1 = _die1._roll();
        private int _roll2 = _die2._roll();
        private int _roll3 = _die3._roll(); 

        //assigned the roll value to each die
        //values assigned to private variables

        public int _dieTotal = int _roll1 + int _roll2 + int _roll3;

        Console.WriteLine($"Die 1 Value: {_roll1}");
        Console.WriteLine($"Die 2 Value: {_roll2}");
        Console.WriteLine($"Die 3 Value: {_roll3}");
        Console.WriteLine($"Total of the three die: {_dieTotal}")


    }
}
