using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Game
    {
        //calling the Die class
        
        //creating a new function taking die as a perameter
        public int[] newDice(int die)
        {
            var Dice = new Die();
            //declating a new List
            var terms = new List<int>();
            //creating a for loop that loops for the amount of die
            for (int i = 0; i < die; i++)
            {
                //adds the rolls the dice item and adds it to the list
                terms.Add(Dice.Roll());
                
            }
            //returns the final array
            return terms.ToArray();
        }
        //declaring a new function SumDice, taking new list as a perameter
        public int SumDice(int[] newList)
        {
            //adds all of the items in the array together
            int sum = newList.Sum();
            //returns the final result
            return sum;

        }
    }
}
