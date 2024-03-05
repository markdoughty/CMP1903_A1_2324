using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        Game _TestGame = new Game();
        Die _TestDie = new Die();
        private int _Roll1;
        private int _Roll2;
        private int _Roll3;
        private int _Before3InARowTest = 0;
        private int _After3InARowTest;


        public string TestGame()
        {
            _TestGame.RollDie();
            _Roll1 = _TestGame.GetRoll1();
            _Roll2 = _TestGame.GetRoll2();
            _Roll3 = _TestGame.GetRoll3();
            _After3InARowTest = _TestGame.Get3InARowCount();
            Debug.Assert(_Roll1 + _Roll2 + _Roll3 == _TestGame.GetTotal());
            if (_Roll1 == _Roll2 && _Roll1 == _Roll3)
            {
                Debug.Assert(_Before3InARowTest != _After3InARowTest);
            }
            else
            {
                Debug.Assert(_Before3InARowTest == _After3InARowTest);
            }
            return "GAME TEST SUCCESSFUL";
        }


        public string TestDie()
        {
            for (int i = 0; i <= 10; i++)
            {
                Debug.Assert(_TestDie.Roll() >= 1 && _TestDie.Roll() <= 6);
                Thread.Sleep(1);
            }
            return "DIE TEST SUCCESSFUL";
        }
    }
}
