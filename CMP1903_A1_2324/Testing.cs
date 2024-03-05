using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
     
        public void GameTest() //GameTest method
        {
            //creates a game object
            Game game = new Game();
            Console.WriteLine("TestGame");
            int test = game.Start(); //this uses the game class method


            Debug.Assert(test > 18 || test>=3,"Game test unsuccessful"); // compares the outcome of the game and check if the total is
            //between 3-18, if otherwise the assertation catches it
            // <black-eye-inc> Review:
            // Please explain your use of "Debug.Assert(...)" -- "Debug.Assert(...)" only flags an error if the input argument
            // (in this case "test > 18 || test>=3") is "false"
            // the input here "test > 18 || test>=3" will always return "true" if test >= 3, I'd recommend "test >= 3 && test < 19"
            // (keeping it in the same style as the next "Debug.Assert(...)" you use)
            // </black-eye-inc>

            Die die = new Die();
            int outcome = die.Roll(); //creates a die object
            
            Debug.Assert(outcome >= 1 && outcome < 7, "Die test unsuccessful");// compares the output of the die
            // <black-eye-inc> Review:
            // Flawless implementation of "Debug.Assert(...)" here
            // </black-eye-inc>
        } 
            
            
            
        

        
    }
}
