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
    public static void Run()
        
        
        {
            Die dieTest = new Die();
            int dieValue = dieTest.Roll();
            Debug.Assert(dieValue >= 1 && dieValue <= 6,"Die roll is out of range.");
            
            
            
            Game gameTest = new Game();
            int totalValue = gameTest.count();
            Debug.Assert(totalValue >= 3 && totalValue <= 18, "Total Score is out of range");
            
            
        
        
        
        
        
        
        }
    

    

    }    
    


    
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
    }

