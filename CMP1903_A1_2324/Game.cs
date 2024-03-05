using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
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

        //Objects
        Die d1 = new Die();
        Die d2 = new Die();
        Die d3 = new Die();
        private int Roll1;
        private int Roll2;
        private int Roll3;
        private int CurrentTotal;
        private int Numof3InaRow = 0;

        //Methods

        //Rolls all 3 die, with a 1ms pause in between rolls to allow for possibility of non-duplicates to occur
        public void RollDie()
        {
            Roll1 = d1.Roll(); 
            Thread.Sleep(1); 
            Roll2 = d2.Roll(); 
            Thread.Sleep(1);
            Roll3 = d3.Roll();
            Thread.Sleep(1);
            if (Roll1 == Roll2 && Roll2 == Roll3)
            {
                Numof3InaRow += 1; //If all rolls are the same, increases the 3 in a row count by 1
            }
        }
        
        //Returns rolls
        public int GetRoll1()
        {
            return Roll1;
        }
        public int GetRoll2()
        {
            return Roll2;
        }
        public int GetRoll3()
        {
            return Roll3;
        }

        //Returns total
        public int GetTotal()
        {
            return (Roll1 + Roll2 + Roll3);
        }

        //Returns 3's in a row
        public int Get3InARowCount()
        {
            return Numof3InaRow;
        }
    }
}
