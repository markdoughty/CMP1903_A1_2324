using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324

{

    class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */


        //Property
        static Random rand = new Random();

        //Method
        public int dice_roll()
        {
            
           
            int value = rand.Next(1, 7);
            return value;
          
        }
    }
    class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //private int dice1 = 0;
        //private int dice2 = 0;
        //private int dice3 = 0;

        Die DiceOne = new Die();
        Die DiceTwo = new Die();
        Die DiceThree = new Die();

        //Methods

        public void DieRoll()
        {
            
            int RollOne = DiceOne.dice_roll();
            Console.WriteLine("You rolled a " + DiceOne);
            
            int RollTwo = DiceTwo.dice_roll();
            Console.WriteLine("You rolled a " + DiceTwo);

            int RollThree = DiceTwo.dice_roll();
            Console.WriteLine("You rolled a " + DiceThree);

            STotal();

        }

        int STotal()
        {
            int Sum = RollOne + RollTwo + RollThree;
            Console.WriteLine("The sum of the dice is:" + Sum);
            return Sum;
        }
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        
            Game newgame = new Game();
            
        }
    }
    public class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        for (int i = 0, i < 500, i++)
    }
}
