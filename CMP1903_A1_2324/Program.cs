using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args) //Main program body
        {
            Game game = new Game(); //Instntiates new game object
            game.RollDie(); //Calls method to roll die
            Console.ReadKey(); //Keeps output window from closing until keystroke.

            Testing test = new Testing(); //Creates testing object where tests run in constructor upon instantiation.
            Console.ReadKey(); 
        }
    }
}
