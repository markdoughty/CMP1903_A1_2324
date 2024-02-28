using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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

        //Methods

        public int  GameRolls()
        {
            Die die1 = new Die();       // this creates 3 dice 
            Die die2 = new Die();
            Die die3 = new Die();

            die1.DiceRoll();
            Thread.Sleep(1);            // this will add a delay of 1 milliseconds to  the dice roll and allow them to be more random 
            die2.DiceRoll();            // this will asign a number to each of the dice 
            Thread.Sleep(1);
            die3.DiceRoll();

            Console.WriteLine("Rolls: ");
            Console.WriteLine(die1.Value);           // this prints the dice values and the sum total of the dice 
            Console.WriteLine(die2.Value);   
            Console.WriteLine(die3.Value);
            int SumOfDice = die1.Value + die2.Value + die3.Value;
            Console.WriteLine("Sum Total off Rolls: ");
            Console.WriteLine(SumOfDice);
            return SumOfDice;
        }


    }
}
