using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Game
    {
        //makes an object that can interact witht the die class
        


        public int Sum()
        {
           //creates 3 roll values so they can be added 
            int total = 0;  
            Die roll = new Die();
            Die roll2 = new Die();
            Die roll3 = new Die();
            List<int> rolls = [roll.diceroll(), roll2.diceroll(), roll3.diceroll()]; //list is used so the rolls are stored and can be used by the following code 
            int i = 0;
            for (i = 0; i < 3;) //loops 3 times 
            {
                //outputs the number rolled and adds that to the total 
                Console.WriteLine(rolls[i]);
                total += rolls[i];
                i += 1;

            }
            //output the total of all three rolls 
            Console.WriteLine("the total of the three rolled values are " + total);
            return total;





        }
    }
}
