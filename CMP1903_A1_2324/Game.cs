using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // creates dice objects / porperties
        public int Total;
        public int Round = 1;
        Die D1 = new Die();
        Die D2 = new Die();
        Die D3 = new Die();


        public void GameRoll()
        {
            Console.WriteLine($"Die1 = {D1.Roll}: \nDie2 = {D2.Roll}: \nDie3 = {D3.Roll}:  ");

        }




        public int Rounds
        {
            get { return Round; }
        }



        public int DieSum
        {
            get { return Total += D1.Value+D2.Value+D3.Value; }
        }




        public int Die_D1
        {
            get { return D1.Value; }
        }

        public int Die_D2
        {
            get { return D2.Value; }
        }

        public int Die_D3
        {
            get { return D3.Value; }
        }


        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example( Total rolls , Total sum, Round sum).
         */

        //Method



    }

}

