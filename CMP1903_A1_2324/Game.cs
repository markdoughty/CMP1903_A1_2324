using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        //Create three dice objects. 
        //Roll all three.
        //Sum and report the total of the three dice rolls.

        //when creating an instance of a class (a new object), you have to write the class name so that
        //it knows which class to construct from
        public Die Die1 = new Die();
        public Die Die2 = new Die();
        public Die Die3 = new Die();

        public int result;
        public void DieCreator()
        {
            Die1.DieValue = Die1.Roll();
            result = Die1.DieValue;
            Console.WriteLine("Die 1: " + Die1.DieValue + "     Total: " + result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Die2.DieValue = Die2.Roll();
            result = result + Die2.DieValue;
            Console.WriteLine("\nDie 2: " + Die2.DieValue + "     Total: " + result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Die3.DieValue = Die3.Roll();
            result = result + Die2.DieValue;
            Console.WriteLine("\nDie 3: " + Die3.DieValue + "     Total: " + result);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
