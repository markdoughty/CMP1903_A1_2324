using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Property
        private int Roll_Value { get; set; } // Encapsulated
        List<int> Die_Faces = new List<int> { 1, 2, 3, 4, 5, 6};
        static Random random = new Random();
        //Method
        public int Roll()
        {
            int i = random.Next(Die_Faces.Count);
            Roll_Value = Die_Faces[i];
            return Roll_Value;
        }

    }
}
