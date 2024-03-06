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
            GameSimulation game = new GameSimulation();
            game.Main();

            Testing test = new Testing();
            test.TestDieValues(die, 3);
        }
    }
}
