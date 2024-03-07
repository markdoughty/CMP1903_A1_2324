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

            Game dicegame = new Game();
            string userinput = "";

            while (userinput != "exit")
            {
                dicegame.rolling();
                userinput = Console.ReadLine();
            }
        }
    }
}
