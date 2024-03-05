using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); //Instantiating a new game object
            int[] Dice = game.AllDieRolls(); //Declaring the integer array of "Dice" which will later store the values of "AllDieRolls"
            game.Results(Dice); //Calls upon the method "Results" within "Game" which will print the results of the game

            Testing testing = new Testing(); //Creates a new testing object
            testing.Test; //Runs the testing class
        }
    }
}
