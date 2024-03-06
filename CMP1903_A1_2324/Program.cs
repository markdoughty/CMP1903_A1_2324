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

            Game game = new Game();
            Testing _testing = new Testing();

            int Total = game.DiceTotal();

            Console.WriteLine($"this is the total of the three dice: {Total}");
            
            Console.ReadLine();

        }
    }
}
