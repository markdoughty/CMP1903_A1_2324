using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private static Testing test = new Testing(); //A new object for Testing is created here, so that tests can be made as soon as possible.
        public void DieGame() //DieGame is the starting point of the program, as seen from Program.cs, which means that these are the first pieces of code to run.
        {
            Die dieOne = new Die(); //creates a die object, which will be used to roll a number between 1 and 6.
            dieOne.Roll(); //uses the die object to start a unique roll method for it.
            int DieOneValue = dieOne.DieValue; //returned integer is set as a value for the die object.

            Die dieTwo = new Die(); //creates a new die object.
            dieTwo.Roll(); //uses the die object to start a unique roll method for it.
            int DieTwoValue = dieTwo.DieValue; //returned integer is set as a value for this unique die object.

            Die dieThree = new Die(); //creates a new die object.
            dieThree.Roll(); //uses the die object to start a unique roll method for it.
            int DieThreeValue = dieThree.DieValue; //returned integer is set as a value for this unique die object.

            test.GameTest(DieOneValue + DieTwoValue + DieThreeValue); //Tests the sum of the three die objects.
            Console.WriteLine($"The sum of three randomly rolled dice is: {DieOneValue + DieTwoValue + DieThreeValue}"); //Shows the user the sum of three die object rolls.
            Console.WriteLine($"Individual rolls are: {DieOneValue}, {DieTwoValue}, {DieThreeValue}"); //Shows the user the die rolls for each specific die object.
            Console.ReadKey(); //ReadKey is used to show the user the outputs, but also to simply close the program with any key press, instead of an input with 'ReadLine'
        }
    }
}
