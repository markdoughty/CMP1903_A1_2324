using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    class Game
    {
            public  int myMethod(int count2, int count3)
            {
                
                int count = 0;
                
                List<int> RollList = new List<int>();

                if (count3 == 0)
                {
                    //Created three die objects 
                    Die Die1 = new Die();
                    Die Die2 = new Die();
                    Die Die3 = new Die();

                    var Roll = Die1.Roll();

                    

                    // Roll all three and saved it in roll 1, 2, 3 
                    Console.WriteLine();
                    int Roll1 = Roll.Item1;
                    int Roll2 = Roll.Item2;
                    int Roll3 = Roll.Item3;

                    //Output what each die roll was
                    Console.WriteLine("Die 1: " + Roll1);
                    Console.WriteLine("Die 2: " + Roll2);
                    Console.WriteLine("Die 3: " + Roll3);

                    //Calculating the total
                    int rolltotal = Roll1 + Roll2 + Roll3;

                    //Displaying the total
                    Console.WriteLine(rolltotal);

                    RollList.Add(Roll1);
                    RollList.Add(Roll2);
                    RollList.Add(Roll3);

                    count = count + 1;
                    
                    return RollList[count2];

                    
                }
                else
                {
                    return RollList[count2];

                }
            }
    }
}
