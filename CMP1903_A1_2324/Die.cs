using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Die
    {
        private int _Roll;

        // rand.Next(5);
        public  int Rolls
        {
                    
            get { return _Roll; }
            set { _Roll = value; }
        }

        public int Roll(int count = 0)
        {
            List<int> RollList = new List<int>();


            // int num2 = this.Rolls;

            // int num3 = this.Rolls;
            // int num = this.Rolls;
            Random rand = new Random();

            int num = rand.Next(1, 7);
            int num2 = rand.Next(1, 7);
            int num3 = rand.Next(1, 7);

            // Console.WriteLine("Five random integers between 50 and 100:");
            for (int i = 1; i <= 3; i++)
                RollList.Add(rand.Next(1, 7));
            
            // Console.Write("{0,8:N0}", rand.Next(1, 7));
            Console.WriteLine();
            // for (int i = 0; i <= RollList.Count; i++)
            // {
            //     return RollList[i];
            //
            // }



            return RollList[count];
            // this.Rolls = num;
            //
            // return num;
            // return num2;
            // return num3;
            //

        }
    }
}
