using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
         public class Die
        {
            private readonly Random _randomValue;
            public Die()
            {
                _randomValue = new Random();
            }
            public int Roll()
            {  
                return _randomValue.Next(1,7);
            }
        }
    }
}
