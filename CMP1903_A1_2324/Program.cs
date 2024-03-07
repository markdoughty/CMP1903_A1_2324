using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PrintTotalValueOfDices(); // runs the class
        
            Testing testing = new Testing();
            testing.TestDiceRolls(); // runs the class
            testing.TestGameSum(); // runs the class
        } 
    }
    
}
