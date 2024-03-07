using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        private int _gameDie;

        private static Random _random = new Random();

        public int Roll()
        {
            _gameDie = _random.Next(1, 7);

            return _gameDie;
        }

    }
}
