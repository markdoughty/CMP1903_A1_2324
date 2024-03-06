using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling the Game class
            var game = new Game();
            //creating a list of 3 dice
            var newList = game.newDice(3);
            
            //outputting the sum of the dice by calling the SumDice function
            Console.WriteLine("the numbers = "+game.SumDice(newList));
            Console.ReadLine();

            //running final test
            //calling the Testing class
            var testing = new Testing(game);

            //running the RunTest class
            testing.RunTest();

           

        }
    }
}
