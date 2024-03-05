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
            
            Game run= new Game();
            
            run.Start();//initial games
            
            
            Testing test = new Testing();
            test.GameTest();// testing the game and Die
            Console.WriteLine(" ");
                
        }
    }
}
