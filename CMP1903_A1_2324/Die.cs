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

        //Property
        public int NumRolled //Creates a public int that will store the value of the number rolled
        {
            set; get;
        }

        //Method
        //Create a random num
        static Random rnd = new Random(); //RNG
        public int RollTheDice() //Empty Integer value which will later be used to store the random value of the dice roll
        {
            NumRolled = rnd.Next(1, 7); //Uses the empty placeholder "NumRolles" to store the random value created in line 24 using 1 and 7 as the parameters
            //(inclusive of 1, exclusive of 7)
            return NumRolled; //Returns the value of the randomised number, effectively storing it
        }
    }
}
