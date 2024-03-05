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
                Game gameObject = new Game();
                gameObject.DiceRoll();
                Testing testing = new Testing();
                testing.DebugProgram();
        }
    }
}
