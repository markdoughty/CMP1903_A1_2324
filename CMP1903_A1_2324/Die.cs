using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Die
    {
        public int rolledNum;

        public void Roll()
        {
            Random rnd = new Random();
            rolledNum = rnd.Next(1, 7);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Die dice = new Die();
            dice.Roll(); 
            Console.WriteLine("Rolled number: " + dice.rolledNum);
        }
    }
}