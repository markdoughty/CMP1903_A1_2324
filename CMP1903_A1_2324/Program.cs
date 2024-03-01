using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args) //Main is used first, as all the functions of this program start from here.
        {
            Game DieRoller = new Game(); //creates a game object called 'DieRoller'.
            DieRoller.DieGame(); //calls the DieGame() method, which is the starting point of the program.
        }
    }
}
