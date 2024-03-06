using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {            //Method
        public static void TestDie()
        {
            Die die = new Die();             // Creates a new Die for testing
            int result = die.Roll();         //Simulates rolling die and get the result

            Debug.Assert(result >= 1 && result <= 6, "Die value should be between 1 and 6.");

           
        }
        public static void TestGame()                       
        {
            Game game = new Game();                        //Creates a new Game for testing
            int total = game.Play();                       //Simulates a game and get the total score

            Debug.Assert(total >= 3 && total <= 18, "Total should be between 3 and 18.");   //Checks if the total falls within the expected range





        }
    }
}
        
        
   





