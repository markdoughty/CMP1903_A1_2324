using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        // runs both methods.
        public Testing()
        {
            TestDiceRollValue();
            TestDiceRollSum();
        }
        public void TestDiceRollValue()
        {
            // Creates new TestVal object
            Die test = new Die();
            int TestVal = test.Roll();

            // Tests if die value is inside bounds
            Debug.Assert(TestVal > 0 && TestVal < 7, "Dice value is out of bounds."); ;
        }

        public void TestDiceRollSum()
        {
            // Creates new TestSum object
            Game testPlay = new Game();
            int TestSum = testPlay.DiceGame();

            // Tests if sum is inside bounds
            Debug.Assert(TestSum > 2 && TestSum < 19, "Total sum of the rolled dice, is out of bounds");
        }
    }
}