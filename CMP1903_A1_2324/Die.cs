using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Dice 
    {
        private int _diceVal = 0;
        public int FinalDie
        { 
          get { return _diceVal; }
          set { _diceVal = value; } 
        }
        Random DiceRoll = new Random();
        public int RollDie()
        {
            
            _diceVal = DiceRoll.Next(1,7);
            Console.WriteLine($"You rolled a {_diceVal}");
            return _diceVal;
        }

    }
}
