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


            string uInput = "";

            while (uInput.ToLower() != "stop")
            {
                game.gameRoll();

                uInput = Console.ReadLine();
                
            }
        }
    }
}
