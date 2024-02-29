using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Die _D1;
        private Die _D2;
        private Die _D3;
        private int _results;



        public Game()
        {
            _D1 = new Die();
            _D2 = new Die();
            _D3 = new Die();
        }


        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public int Sumup()
        {
            int D1Roll =_D1.roll();
            int D2Roll = _D2.roll();
            int D3Roll = _D3.roll();
            int result = D1Roll + D2Roll + D3Roll;
            return result;
        }

        


    }
}
