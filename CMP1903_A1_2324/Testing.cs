using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public void DieTest(int value)
        {
            Debug.Assert(value <= 6, "Die generated above the value of 6 (Max)");
            Debug.Assert(value >= 1, "Die generated below the value of 1 (Min)");
        }

        public void GameTest(int value)
        {
            Debug.Assert(value <= 18, "Sum above the value of 18 (Max)");
            Debug.Assert(value >= 3, "Sum below the value of 3 (Min)");
        }
    }
}
