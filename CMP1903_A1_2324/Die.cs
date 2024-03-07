using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CMP1903_A1_2324;

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
        Die DiceTwo = new Die();    //created Three die objects
        Die DiceThree = new Die();

        //Methods

        public int DieRoll()
        {
            
            int RollOne = DiceOne.dice_roll();
            Console.WriteLine("You rolled a " + DiceOne);
            
            int RollTwo = DiceTwo.dice_roll();
            Console.WriteLine("You rolled a " + DiceTwo);       //The three created die are rolled

            int RollThree = DiceTwo.dice_roll();
            Console.WriteLine("You rolled a " + DiceThree);
            
            int Sum = RollOne + RollTwo + RollThree;
            Console.WriteLine("The sum of the dice is:" + Sum);     //The totals of the die are added together and returned.
            return Sum;

        }
  
    }

    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        Game Test = new Game();     //Game object created
        Die TestDie = new Die();    //Test object created

        }


    }

   internal class Testing
   {
        Game Test = new Game();     //Game object created
        Die TestDie = new Die();    //Test object created
        public void TestRolls()
        {
            for (int i = 0; i < 500; i++)
            {
                int testvalue = TestDie.dice_roll();

                Debug.Assert(testvalue < 7 && testvalue > 0);

                int testsum = TestDie.dice_roll();

                Debug.Assert(testsum < 19 && testsum > 2);
            
            }
        }
   }

}