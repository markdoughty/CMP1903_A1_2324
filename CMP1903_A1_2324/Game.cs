using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {

        
        //Sum and report the total of the three dice rolls.

        //when creating an instance of a class (a new object), you have to write the class name so that
        //it knows which class to construct from
        //Creates three new dice objects
        public Die Die1 = new Die();
        public Die Die2 = new Die();
        public Die Die3 = new Die();

        public int result;
        public void DieCreator()
        {
            //Rolls Die1 and assigns the value to result. Then outputs Die1 and the running total sum to the screen
            //The readKey line makes the user input any key to continue running the program
            Die1.DieValue = Die1.Roll();
            result = Die1.DieValue;
            Console.WriteLine("Die 1: " + Die1.DieValue + "     Total: " + result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Rolls Die2 and assigns the value of Die2 + Die1 from previously to result.
            //Then outputs Die2 and the running total sum to the screen
            Die2.DieValue = Die2.Roll();
            result = result + Die2.DieValue;
            Console.WriteLine("\nDie 2: " + Die2.DieValue + "     Total: " + result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            //Rolls Die3 and assigns the value of Die3 + Die2 + Die1 from previously to result.
            //Outputs Die3 and the final total sum of the die to the screen
            Die3.DieValue = Die3.Roll();
            result = result + Die2.DieValue;
            Console.WriteLine("\nDie 3: " + Die3.DieValue + "     Total: " + result);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
