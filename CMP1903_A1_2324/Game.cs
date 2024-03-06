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
        private int _Roll1;
        private int _Roll2;
        private int _Roll3;
        private int _CurrentTotal;
        private int _Numof3InaRow = 0;

        //Methods

        //Rolls all 3 die, with a 1ms pause in between rolls to allow for possibility of non-duplicates to occur
        public void RollDie()
        {
            _Roll1 = d1.Roll(); 
            Thread.Sleep(1); 
            _Roll2 = d2.Roll(); 
            Thread.Sleep(1); //Since randomness uses timestamps, sleeps for 1 millesecond to allow for a change in timestamp
            _Roll3 = d3.Roll();
            Thread.Sleep(1);
            if (_Roll1 == _Roll2 && _Roll2 == _Roll3)
            {
                _Numof3InaRow += 1; //If all rolls are the same, increases the 3 in a row count by 1
            }
        }
        
        //Returns rolls
        public int GetRoll1()
        {
            return _Roll1;
        }
        public int GetRoll2()
        {
            return _Roll2;
        }
        public int GetRoll3()
        {
            return _Roll3;
        }

        //Returns total
        public int GetTotal()
        {
            return (_Roll1 + _Roll2 + _Roll3);
        }

        //Returns 3's in a row
        public int Get3InARowCount()
        {
            return _Numof3InaRow;
        }
    }
}
