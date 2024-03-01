using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Dice 
    {
        public int FinalDie //Public variable encapsulates _diceVal
        { 
          get { return _diceVal; }
          set { _diceVal = value; } 
        }

        private int _diceVal = 0;

        Random random = new Random(); //Creates a new Random object
        public int RollDie()
        {
            
            _diceVal = random.Next(1,7); //Generates a random number between 1 and6
            Console.WriteLine($"You rolled a {_diceVal}");
            return _diceVal;
        }

    }
}


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
            set {  _sum = value; }
        }
        private int _sum = 0; //Private variable sum
        public void Play() //Main method for the class
        {
            Dice dice = new Dice(); //Creates a new dice object
            int diceVal = 0;
            
            for (int i = 0;i<=2;i++) //Loops 3 times to roll the dice 3 times and add the number roll to the sum
            {
                diceVal = dice.RollDie(); //Calls the roll die method on the dice objects and the returning integer is set as DieVal
                _sum = _sum + diceVal;
            }
            FinalSum = _sum;
            Console.WriteLine($"The sum of the three dice rolls is {_sum}");
        }

    }
}


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
            Game game = new Game(); //Creates a new game object
            game.Play(); //Calls the play function for the game object
            
            Testing testing = new Testing();//Creates a new game object
            testing.TestGame(); //Calls the test game function on thr testing object

            Console.ReadLine();

        }
    }
}


public void TestGame()  //Runs the game method and dice method
        {
            Console.WriteLine("Testing Game Object");
            Game game = new Game(); //Creates a new Game object called game
            game.Play();
            Debug.Assert(2<game.FinalSum && game.FinalSum < 25 ); //Checks that the final sum is possilbe one 3 6 sided dice
            
            Console.WriteLine("Testing Dice Object");
            Dice dice = new Dice(); //Creates a new Dice object called dice
            dice.RollDie();
            Debug.Assert(0<dice.FinalDie&&dice.FinalDie<7); //Checks that the dice rolls between 1 and 6
        }

