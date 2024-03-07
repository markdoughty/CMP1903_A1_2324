using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        private readonly Die number1; // creates a object
        private readonly Die number2; // creates a object
        private readonly Die number3; // creates a object
        public Game() 
        {   
            number1 = new Die(); //use class die to create the random number
            number2 = new Die();//use class die to create the random number
            number3 = new Die();//use class die to create the random number
        }
        public int TotalValueOfDices() 
        {
            return number1.Roll() + number2.Roll() + number3.Roll(); // rools and sum all the numbers
        } 
        public void PrintTotalValueOfDices()
        {
            int sum = TotalValueOfDices();
            Console.WriteLine("The sum of TotalValueOfDices is: " + sum);  // output the sum of the number to the user
        }
    }
    
}
