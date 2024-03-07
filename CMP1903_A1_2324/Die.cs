using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value*/
        private int Roll_Value { get; set; }

        // List of possible faces of the die
        private int[] _dieFaces = { 1, 2, 3, 4, 5, 6 };

        // Random number generator
        private static Random random = new Random();

        /* and one method that rolls the die, returns and integer and takes no parameters.
        */
        public int Roll()
        {
            int index = random.Next(_dieFaces.Length);
            Roll_Value = _dieFaces[index];
            Console.WriteLine("Die Roll: " + Roll_Value);
            return Roll_Value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Die class
            Die die = new Die();

            // Roll the die
            die.Roll();
        }
    }
}
