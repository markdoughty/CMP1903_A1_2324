using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        public int FinalSum //Public variable that sets and gets the private variable sum
        {
            get { return _sum; }
            set { _sum = value; }
        }
        private int _sum = 0; //Private variable sum
        public void Play(bool Test) //Main method for the class
        {
            Console.WriteLine("Playing Game");
            Dice dice = new Dice(); //Creates a new dice object
            int diceVal = 0;

            for (int i = 0; i <= 2; i++) //Loops 3 times to roll the dice 3 times and add the number roll to the sum
            {
                diceVal = dice.RollDie(); //Calls the roll die method on the dice objects and the returning integer is set as DieVal
                _sum = _sum + diceVal;
            }
            FinalSum = _sum;
            Console.WriteLine($"The sum of the three dice rolls is {_sum}");
            if (Test == false) //Checks if it is a test before asking to roll again
            {
                while (RollAgain().ToUpper() == "Y") //If the response is Y, it rolls a dice
                {
                    FinalSum += dice.RollDie();
                    Console.WriteLine($"New sum = {FinalSum}"); //Shows the new total
                }
            }
        }
        private string RollAgain() //Asks if another dice should be rolled and handles the response
        {
            Console.WriteLine("Do you want to roll another dice? Y/N");
            string ConsoleResponse = Console.ReadLine();
            Response(ConsoleResponse);
            
            return ConsoleResponse;
        }
        private void Response(string Response) //Forces the reply to be Y or N to continue
        {
         bool Valid = false;
           while (Valid == false) //While loop forces a correct response to continue
            {
             if (Response.ToUpper() != "Y" & Response.ToUpper() != "N") //Checks if the response is Y or N
              {
                    Console.WriteLine("Response not valid"); 
              }
             else
                { 
                 Valid = true; //Ends the while loop if the response is valid
                }
            }
         
        }
    }
}



