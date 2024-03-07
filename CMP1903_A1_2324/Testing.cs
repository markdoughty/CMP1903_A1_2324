using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // runs both methods.
        public Testing() {
            TestDiceRollValue();
            TestDiceRollSum();
        }
        public void TestDiceRollValue()
        {
            // Creates new TestVal object
            Die test = new Die();
            int TestVal = test.Roll();
    }
}
