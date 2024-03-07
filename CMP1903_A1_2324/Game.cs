using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public class Game
        {
            private readonly Die number1;
            private readonly Die number2;
            private readonly Die number3;
            public Game() 
            {   
                number1 = new Die();
                number2 = new Die();
                number3 = new Die();
            }
            public int TotalValueOfDices() 
            {
                return number1.Roll() + number2.Roll() + number3.Roll();
            }
            public void PrintTotalValueOfDices()
            {
                int sum = TotalValueOfDices();
                Console.WriteLine("The sum of TotalValueOfDices is: " + sum);
            }
        }
    }
}
