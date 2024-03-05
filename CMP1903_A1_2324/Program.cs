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
            //creates new object of game class
            Game Game1 = new Game();

            Game1.DieCreator();

            //creates a new object of the testing class
            Testing Test1 = new Testing();

        }
    }
}
