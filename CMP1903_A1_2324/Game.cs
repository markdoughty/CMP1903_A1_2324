using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        public int Total { get; private set; }



        //Methods
        public void PlayGame()
        { 
            Die myFirstDie = new Die();          //new instance of die called myDie
            myFirstDie.CurrentDieVal = 1;        //give currentdievalue an initial value

            Die mySecondDie = new Die();        //second instance called my second die
            mySecondDie.CurrentDieVal = 1;

            Die myThirdDie = new Die();         //third insntance called my third die
            myThirdDie.CurrentDieVal = 1;


            myFirstDie.RollDie();                                                                   //roll first die
            Console.WriteLine($"The value on the first die is:  {myFirstDie.CurrentDieVal}");       //print to screen value of first die

            mySecondDie.RollDie();                                                                   //roll second die
            Console.WriteLine($"The value on the second die is:  {mySecondDie.CurrentDieVal}");      //print to screen value of second die

            myThirdDie.RollDie();                                                                   //roll third die
            Console.WriteLine($"The value on the third die is:  {myThirdDie.CurrentDieVal}");       //print to screen value of third die

            Total = myFirstDie.CurrentDieVal + mySecondDie.CurrentDieVal + myThirdDie.CurrentDieVal;
            Console.WriteLine($"The sum of the dice values are: {Total}");
        }
    }
}
