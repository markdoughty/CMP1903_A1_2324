using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */
        public int _value; //creates a field so the value of the die can be accessed by other classes

        //Property
        public int value //creates a property of the class to store the value of the die 
        {
            get { return _value; } //returns the value of 'value'
            set { _value = value; } //stores the returned value into '_value'
        }

        //Method

        //this method generates a random number and returns it
        public int Roll() //initialises method 'Roll'
        {
            string choice = " ";
            bool loop = true;
            while (loop == true)
            {
                Random rnd = new Random(); //creates a random number 
                value = rnd.Next(1, 6); //stores random nubmer in set range of 1-6 in public variable 'value'

                try
                {
                    Console.WriteLine($"number rolled = {value}");

                    Console.WriteLine("Do you want to roll again? (y/n): ");
                    choice = Console.ReadLine();
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("No choice entered, please try again...");
                }
                catch (FormatException)
                {
                    Console.WriteLine("you did not input a letter, please try again...");
                }

                if (choice == "n")
                {
                    loop = false;
                }
                else if (choice != "y" || choice != "n")
                {
                    Console.WriteLine("invalid input, please try again...\n");
                    loop = false;
                }

            }
            return value;
        }
    }
}
