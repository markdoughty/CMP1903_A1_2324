using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        //Property
        Die randomobj = new Die();
        Die randomobj2 = new Die();
        Die randomobj3 = new Die();
        
        public Die Die1
        {
            get { return randomobj; }
            private set { randomobj = value; }
        }

        public Die Die2
        {
            get { return randomobj2; }
            private set { randomobj2 = value; }
        }

        public Die Die3
        {
            get { return randomobj3; }
            private set { randomobj3 = value; }
        }
        //Methods

        public int DiceRoll()
        {
        int value1 = randomobj.Roll();
        int value2 = randomobj2.Roll();
        int value3 = randomobj3.Roll();
            int value4 = value1 + value2 + value3;
            return value4; 
        }

    }
}
