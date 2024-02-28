using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
            
             
             
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Console.WriteLine("Enter the number of dice you want to roll: ");
            // user input is converted to an interger to be able to add.
            int dice_user_input = Convert.ToInt32(Console.ReadLine());
          
            Random rng = new Random();
           
            int Random_Number = rng.Next(dice_user_input);  
           // for loop which makes it so it prints out the statement and the number for the amount of numbers that the user has asked it to print out,
            for (int j = 0; j < dice_user_input; j++)
            {
                
                Console.WriteLine("the numbers the dice rolled: " + rng.Next(dice_user_input));
            }
            int sum_of_dice;
            sum_of_dice = Random_Number + (Random_Number);
            
            //int sum_of_dice = ;
            Console.WriteLine("The number of all of the dice added together is: {0} " ,(sum_of_dice));
            
            
            
            
            Console.ReadKey();
        
        }

    }
}
