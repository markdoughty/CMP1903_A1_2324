using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Game
    {
        public  Tuple<int, int, int> myMethod()
        {
                
            int count = 0;
                
            List<int> RollList = new List<int>();

                
            
                //Created three die objects 
                Die Die1 = new Die();
               


                    

                // Roll all three and saved it in roll 1, 2, 3 
                Console.WriteLine();
                int Roll1 = Die1.Roll();
                int Roll2 = Die1.Roll();
                int Roll3 = Die1.Roll();

                //Output what each die roll was
                Console.WriteLine("Die 1: " + Roll1);
                Console.WriteLine("Die 2: " + Roll2);
                Console.WriteLine("Die 3: " + Roll3);

                //Calculating the total
                int rolltotal = Roll1 + Roll2 + Roll3;

                //Displaying the total
                Console.WriteLine("The total amoubnt is " +rolltotal);

                RollList.Add(Roll1);
                RollList.Add(Roll2);
                RollList.Add(Roll3);



                return new Tuple<int, int, int>(RollList[0], RollList[1], RollList[2]);




            
        }
    }
}